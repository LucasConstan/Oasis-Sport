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
            if(SessionManager.GetInstance().IsLogged())
            {
                SessionManager.GetInstance().Logout();
                MessageBox.Show("Sesion cerrada con exito");
            }
            else
            {
                MessageBox.Show("No existe una sesion activa");
            }
        }
    }
}
