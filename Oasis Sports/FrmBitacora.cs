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
    public partial class FrmBitacora : Form
    {
        BLL_Evento bllEvento = new BLL_Evento();

        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void CargarBitacora()
        {
            dgvBitacora.DataSource = bllEvento.ListarEventos();
        }

        private void dgvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBitacora_Load_1(object sender, EventArgs e)
        {           
            CargarBitacora();
        }
    }
}
