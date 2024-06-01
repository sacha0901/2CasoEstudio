using Domain.Models;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentation.Forms
{
    public partial class FrmDatos : Form
    {
        private DatosModel datos = new DatosModel();
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            ListDatos();
            pGuardar.Enabled = false;
        }
        private void ListDatos()
        {
            try
            {
                dgvDatos.DataSource = datos.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearchDatos_TextChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = datos.FindById(txtSearchDatos.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            datos.Fecha = dtpFecha.Value;
            datos.Hora = dtpHora.Value;
            datos.Temperatura = txtTemperatura.Text;
            datos.Humedad = txtHumedad.Text;

                string result = datos.SaveChanges();
                MessageBox.Show(result);
                ListDatos();
                Restart();
        }
        private void Restart()
        {
            pGuardar.Enabled = true;

            txtTemperatura.Clear();
            txtHumedad.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pGuardar.Enabled = true;
            datos.State = EntityState.Added;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                pGuardar.Enabled = true;
                datos.State = EntityState.Modified;
                datos.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                dtpFecha.Value = Convert.ToDateTime(dgvDatos.CurrentRow.Cells[1].Value);
                dtpHora.Value = Convert.ToDateTime(dgvDatos.CurrentRow.Cells[2].Value);
                txtTemperatura.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
                txtHumedad.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Select row o seleccionar filas");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                datos.State = EntityState.Deleted;
                datos.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                string result = datos.SaveChanges();
                MessageBox.Show(result);
                ListDatos();
            }
            else
            {
                MessageBox.Show("Select row o seleccionar filas");
            }
        }
    }
}
