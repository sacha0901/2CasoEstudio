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

namespace Presentation.Forms
{
    public partial class FrmMain : Form
    {
        private bool Conected = false;
        private string strBufferIn = "";
        private string strBufferOut = "";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            BtnConect.Enabled = false;
        }
        private void CargarPuertos()
        {
            CboPorts.Items.Clear();
            CboPorts.Items.AddRange(SerialPort.GetPortNames());
            if (CboPorts.Items.Count > 0)
            {
                CboPorts.SelectedIndex = 0;
                BtnConect.Enabled = true;
                MessageBox.Show("Select the working port");
            }
            else
            {
                MessageBox.Show("No ports detected");
                BtnConect.Enabled = false;
            }
        }
        private void BtnConect_Click_1(object sender, EventArgs e)
        {
             if (Conected)
            {
                Desconectar();
            }
            else
            {
                Conectar();
            }
        }
        private void Conectar()
        {
            try
            {
                SpPorts.BaudRate = int.Parse(CboBaudRate.Text);
                SpPorts.DataBits = 8;
                SpPorts.Parity = Parity.None;
                SpPorts.StopBits = StopBits.One;
                SpPorts.Handshake = Handshake.None;
                SpPorts.PortName = CboPorts.Text;

                SpPorts.DataReceived += SpPorts_DataReceived_1;
                SpPorts.Open();
                pictureBox1.BackColor = Color.GreenYellow;
                Conected = true;
                BtnConect.Text = "Disconnect";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting: {ex.Message}");
                Desconectar();
            }
        }

        private void Desconectar()
        {
            if (SpPorts.IsOpen)
            {
                SpPorts.Close();
                SpPorts.DataReceived -= SpPorts_DataReceived_1;
            }
            Conected = false;
            BtnConect.Text = "Connect";
            pictureBox1.BackColor = Color.Black;

        }
        private void SpPorts_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
  try
            {
                string dataIn = SpPorts.ReadLine();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recibir datos: {ex.Message}");
            }
        }
        private void BtnSearchPorts_Click_1(object sender, EventArgs e)
        {
            CargarPuertos();
        }
        private void EnviarDatos(string datos)
        {
            if (Conected && SpPorts.IsOpen)
            {
                try
                {
                    SpPorts.WriteLine(datos);
                    MessageBox.Show("Datos enviados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar datos: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No está conectado al puerto serial.");
            }
        }

    }
}
