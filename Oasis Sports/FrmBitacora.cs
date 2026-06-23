using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Oasis_Sports
{
    public partial class FrmBitacora : BaseForm
    {
        BLL_Evento bllEvento = new BLL_Evento();

        DataTable tablaEventos;

        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void CargarBitacora()
        {
            tablaEventos = bllEvento.ListarEventos();

            dgvBitacora.DataSource = tablaEventos;
        }

        private void dgvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBitacora_Load_1(object sender, EventArgs e)
        {
            CargarBitacora();

            cmbCriticidad.Items.Add("Todas");
            cmbCriticidad.Items.Add("1");
            cmbCriticidad.Items.Add("2");
            cmbCriticidad.Items.Add("3");
            cmbCriticidad.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView vista = tablaEventos.DefaultView;

            string filtro = "";

            
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                filtro += $"Usuario LIKE '%{txtUsuario.Text}%'";
            }

           
            if (cmbCriticidad.Text != "Todas")
            {
                if (filtro != "")
                    filtro += " AND ";

                filtro += $"Criticidad = {cmbCriticidad.Text}";
            }

            
            if (filtro != "")
                filtro += " AND ";

            filtro += $"Fecha >= #{dtpDesde.Value:yyyy-MM-dd}#";
            filtro += $" AND Fecha <= #{dtpHasta.Value:yyyy-MM-dd 23:59:59}#";

            vista.RowFilter = filtro;

            dgvBitacora.DataSource = vista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();

            cmbCriticidad.SelectedIndex = 0;

            dtpDesde.Value = DateTime.Today.AddMonths(-1);

            dtpHasta.Value = DateTime.Today;

            dgvBitacora.DataSource = tablaEventos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
