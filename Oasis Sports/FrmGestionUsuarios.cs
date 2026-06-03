using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oasis_Sports
{
    public partial class FrmGestionUsuarios : BaseForm
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        BLLUsuario bllUsuario = new BLLUsuario();

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtContraseñaRepetida.Text == txtContraseña.Text  && txtUsuario.Text != "")
            {
                Usuario usuario = new Usuario();
                usuario.Username = txtUsuario.Text;
                usuario.Password = txtContraseñaRepetida.Text;

                bllUsuario.AñadirUsuario(usuario);
                dataGridView1.DataSource = bllUsuario.Listar();

                MessageBox.Show("Usuario añadido correctamente");
            }

            else
            {
                MessageBox.Show("Error en la carga de datos");
            }
            

        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllUsuario.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
