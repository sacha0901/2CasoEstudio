using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                var validLogin = user.LoginUser(txtUsuario.Text, txtClave.Text);

                if (validLogin == true)
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
    }
}
