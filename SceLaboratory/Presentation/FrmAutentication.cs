using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class FrmAutentication : Form
    {
        private bool Conected = false;
        private string strBufferIn = "";
        private string strBufferOut = "";
        private string dato = "";
        private string coordinador = "ECoordinador";
        public FrmAutentication()
        {
            InitializeComponent();
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El campo usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpClave.SetError(txtClave, "El campo contraseña es obligatorio");
                esValido = false;
            }
            return esValido;
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                UserModel user = new UserModel();
                var validUser = user.LoginUser(txtUsuario.Text, txtClave.Text);

                if (validUser == true)
                {
                    FrmHome mainMenu = new FrmHome();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "::: Minerva - Mensaje :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void FrmAutentication_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConectLogin.Enabled = false;

        }
        private void BtnSearchPortsLogin_Click(object sender, EventArgs e)
        {
            CargarPuertos();
        }
        private void CargarPuertos()
        {
            CboPortsLogin.Items.Clear();
            CboPortsLogin.Items.AddRange(SerialPort.GetPortNames());
            if (CboPortsLogin.Items.Count > 0)
            {
                CboPortsLogin.SelectedIndex = 0;
                BtnConectLogin.Enabled = true;
                MessageBox.Show("Select the working port");
            }
            else
            {
                MessageBox.Show("No ports detected");
                BtnConectLogin.Enabled = false;
            }
        }

        private void BtnConectLogin_Click(object sender, EventArgs e)
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
                SpPortsLogin.BaudRate = int.Parse(CboBaudRateLogin.Text);
                //SpPortsLogin.ReadTimeout = 1000;
                //SpPortsLogin.WriteTimeout = 1000;
                SpPortsLogin.DataBits = 8;
                SpPortsLogin.Parity = Parity.None;
                SpPortsLogin.StopBits = StopBits.One;
                SpPortsLogin.Handshake = Handshake.None;
                SpPortsLogin.PortName = CboPortsLogin.Text;
                SpPortsLogin.Open();
                SpPortsLogin.DataReceived += SpPortsLogin_DataReceived;
                pictureBox1.BackColor = Color.GreenYellow;
                Conected = true;
                BtnConectLogin.Text = "Disconnect";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting: {ex.Message}");
                Desconectar();
            }
        }

        private void Desconectar()
        {
            if (SpPortsLogin.IsOpen)
            {
                SpPortsLogin.Close();
                SpPortsLogin.DataReceived -= SpPortsLogin_DataReceived;
            }
            Conected = false;
            BtnConectLogin.Text = "Connect";
            pictureBox1.BackColor = Color.Black;

        }
       
        private void SpPortsLogin_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
                try
                {
                    dato = SpPortsLogin.ReadLine().Trim();
                    txbDato.Invoke(new MethodInvoker(delegate {
                        txbDato.Text = dato;
                        ValidarRFID(dato);
                    }));

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al recibir datos: {ex.Message}");
                } 
        }
        private void ValidarRFID(string dato)
        {
            // Log de depuración
            Console.WriteLine($"Dato recibido: '{dato}'");

            if (dato == coordinador)
            {
                // Desconectar el puerto antes de abrir el nuevo formulario
                // Asegúrate de que esto se haga en el hilo de la UI
                this.Invoke(new Action(() =>
                {
                    FrmHome mainMenu = new FrmHome();
                    mainMenu.Show();
                    this.Hide();
                }));
            }
            else
            {
                // Mostrar el mensaje en el hilo de la UI
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Tarjeta RFID no válida", "::: Minerva - Mensaje :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

    }
}
