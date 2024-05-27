using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Clases;

namespace Presentation
{
    public partial class FrmHome : Form
    {
        double temperatura = 0, humedad = 0;
        bool actualizarDato = false;
        //int tabla = 1;

        private String strBufferIn;
        private String strBufferOut;
        public FrmHome()
        {
            InitializeComponent();
        }
        bool Conected = false;
        private void FrmHome_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConect.Enabled = false;
            ConexionBD conexion = new ConexionBD();
            conexion.AbrirCn();
            graficaTemp.Series["Temperatura"].Points.AddXY(1, 1);
            graficaHumedad.Series["Humedad"].Points.AddXY(1, 1);

        }

        private void BtnConect_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conected == false)
                {
                    SpPorts.BaudRate = Int32.Parse(CboBaudRate.Text);
                    SpPorts.DataBits = 8;
                    SpPorts.Parity = Parity.None;
                    SpPorts.StopBits = StopBits.One;
                    SpPorts.Handshake = Handshake.None;
                    SpPorts.PortName = CboPorts.Text;

                    graficaTemp.Series["Temperatura"].Points.Clear();
                    graficaHumedad.Series["Humedad"].Points.Clear();

                    try
                    {
                        SpPorts.Open();                     
                        pictureBox1.BackColor = Color.GreenYellow;
                        Conected = true;
                        BtnConect.Text = "Disconnect";
                        graficaTemp.Series["Temperatura"].Points.Clear();
                        graficaHumedad.Series["Humedad"].Points.Clear();
                        graficaHumedad.Enabled = true;
                        graficaTemp.Enabled = true;
                        actualizarDgv.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    SpPorts.Close();
                    actualizarDgv.Enabled = false;
                   
                    pictureBox1.BackColor = Color.Black;
                    Conected = false;
                    BtnConect.Text = "Conect";
                    actualizarDgv.Enabled = false;
                    graficaHumedad.Enabled = false;
                    graficaTemp.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private void BtnSearchPorts_Click(object sender, EventArgs e)
        {
            string[] AvailablePorts = SerialPort.GetPortNames();

            CboPorts.Items.Clear();

            foreach (string simple_port in AvailablePorts)
            {
                CboPorts.Items.Add(simple_port);
            }

            if (CboPorts.Items.Count > 0)
            {
                CboPorts.SelectedIndex = 0;
                MessageBox.Show("Select the working port");
                BtnConect.Enabled = true;
            }
            else
            {
                MessageBox.Show("no port detected");
                CboPorts.Items.Clear();
                CboPorts.Text = "                     ";
                strBufferIn = "";
                strBufferOut = "";
                BtnConect.Enabled = false;
            }
        }

        private void SpPorts_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataIn = SpPorts.ReadTo("\n");
            analizarDatos(dataIn);
            this.BeginInvoke(new EventHandler(mostrarDatos));
        }

        private void mostrarDatos(object sender, EventArgs e)
        {
            if(actualizarDato == true)
            {
                graficaTemp.Series["Temperatura"].Points.Add(temperatura);
                graficaHumedad.Series["Humedad"].Points.Add(humedad);
            }           
        }
        //---------------------Obtengo los datos del sensor
        private void analizarDatos(string dato)
        {
            sbyte caracterInicio = (sbyte)dato.IndexOf("@");
            sbyte caracterA = (sbyte)dato.IndexOf("A");
            sbyte caracterB = (sbyte)dato.IndexOf("B");

            if(caracterA!=-1 && caracterB!=-1 && caracterInicio!= -1)
            {
                try
                {
                    string str_Temperatura = dato.Substring(caracterInicio + 1, (caracterA - caracterInicio) - 1);
                    string str_Humedad = dato.Substring(caracterA+1, (caracterB - caracterA) - 1);

                    temperatura = Convert.ToDouble(str_Temperatura) / 100;
                    humedad = Convert.ToDouble(str_Humedad) / 100;

                    actualizarDato = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                actualizarDato = false;
            }
        }
        //----------------------------End

        private void insertarDatos()
        {
            Datos datos = new Datos();
            datos.Fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            datos.Hora = Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss"));
            datos.Temperatura = Convert.ToDouble(temperatura.ToString());
            datos.Humedad = Convert.ToDouble(humedad.ToString());
            datosCRUD.Insertar(datos);
        }

        private void actualizarDgv_Tick(object sender, EventArgs e)
        {
            insertarDatos();
            CargarDatos();
           

        }

        private void CargarDatos()
        {
            dgvDatos.DataSource = datosCRUD.ObtenerDatos();
        }
    }
}
