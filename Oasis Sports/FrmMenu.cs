using BLL;
using Entidades;
using Servicios;
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
    public partial class FrmMenu : BaseForm
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SessionManager.GetInstance().IsLogged())
            {
                BLL_Evento bllEvento = new BLL_Evento();

                bllEvento.RegistrarEvento(new Evento()
                    {
                        Usuario = SessionManager.GetInstance().Usuario.Username,
                        Modulo = "Login",
                        Descripcion = "Cierre de sesión",
                        Fecha = DateTime.Now,
                        Criticidad = 1
                    });

                SessionManager.GetInstance().Logout();
                MessageBox.Show("Sesion cerrada con exito");
            }
            else
            {
                MessageBox.Show("No existe una sesion activa");
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBitacora frm = new FrmBitacora();

            frm.ShowDialog();
        }
    }
}
