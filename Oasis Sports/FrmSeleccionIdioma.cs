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
using Entidades;
using Servicios;

namespace Oasis_Sports
{
    public partial class FrmSeleccionIdioma : Form
    {
        BLL_Idioma bllIdioma = new BLL_Idioma();

        public FrmSeleccionIdioma()
        {
            InitializeComponent();
        }

        private void FrmSeleccionIdioma_Load(object sender, EventArgs e)
        {
            cmbIdiomas.DataSource = bllIdioma.Listar();
            cmbIdiomas.DisplayMember = "Nombre";
            cmbIdiomas.ValueMember = "IdIdioma";
        }

        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbIdiomas.SelectedValue == null) return;

            int idIdioma = (int)cmbIdiomas.SelectedValue;
            LanguageManager.GetInstance().CambiarIdioma(idIdioma);

            this.Close();
        }

        
        
    }
}