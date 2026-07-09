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
    public partial class FrmMenu : BaseForm, IObserverIdioma
    {
        public FrmMenu()
        {
            InitializeComponent();
            LanguageManager.GetInstance().Agregar(this);
        }

        public void ActualizarPermisos()
        {
            OcultarControles();
            if (SessionManager.GetInstance().IsLogged())
                AplicarPermisos();
        }

        public void ActualizarIdioma()
        {
            LanguageManager.GetInstance().TraducirControles(this);

            
            var lm = LanguageManager.GetInstance();

            uSUARIOToolStripMenuItem.Text = lm.ObtenerTexto("uSUARIOToolStripMenuItem");
            lOGINToolStripMenuItem.Text = lm.ObtenerTexto("lOGINToolStripMenuItem");
            lOGOUTToolStripMenuItem.Text = lm.ObtenerTexto("lOGOUTToolStripMenuItem");
            bitacoraToolStripMenuItem.Text = lm.ObtenerTexto("bitacoraToolStripMenuItem");
            bITACORAToolStripMenuItem1.Text = lm.ObtenerTexto("bITACORAToolStripMenuItem1");
            gESTIONDEUSUARIOSToolStripMenuItem.Text = lm.ObtenerTexto("gESTIONDEUSUARIOSToolStripMenuItem");
            gESTIONDEPERFILESToolStripMenuItem.Text = lm.ObtenerTexto("gESTIONDEPERFILESToolStripMenuItem");
            bITACORADECAMBIOSToolStripMenuItem.Text = lm.ObtenerTexto("bITACORADECAMBIOSToolStripMenuItem");
            gESTIONDERESERVASToolStripMenuItem.Text = lm.ObtenerTexto("gESTIONDERESERVASToolStripMenuItem");
            gESTIONDEIDIOMASToolStripMenuItem.Text = lm.ObtenerTexto("gESTIONDEIDIOMASToolStripMenuItem");
            sALIRToolStripMenuItem.Text = lm.ObtenerTexto("sALIRToolStripMenuItem");
        }


        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            LanguageManager.GetInstance().Quitar(this);
        }



        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault();
            if (frmLogin == null)
                frmLogin = new FrmLogin();

            frmLogin.Show();
            this.Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de cerrar sesion?", "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
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
                    OcultarControles();
                }
                else
                {
                    MessageBox.Show("No existe una sesion activa");
                }
            }
        }

        BLL_Permisos permisosBLL = new BLL_Permisos();

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            OcultarControles();
            if (!SessionManager.GetInstance().IsLogged())
                return;

            AplicarPermisos();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void bITACORAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBitacora frm = new FrmBitacora();
            frm.ShowDialog();
        }

        private void bitacoraToolStripMenuItem_VisibleChanged(object sender, EventArgs e) { }

        private void OcultarControles()
        {
            bitacoraToolStripMenuItem.Visible = false;
            bITACORAToolStripMenuItem1.Visible = false;
            gESTIONDEUSUARIOSToolStripMenuItem.Visible = false;
            gESTIONDEPERFILESToolStripMenuItem.Visible = false;
            gESTIONDERESERVASToolStripMenuItem.Visible = false;
            gESTIONDEIDIOMASToolStripMenuItem.Visible = false;
            bITACORADECAMBIOSToolStripMenuItem.Visible = false;

        }

        private void AplicarPermisos()
        {
            if (SessionManager.GetInstance().IsLogged())
            {
                bITACORAToolStripMenuItem1.Visible = permisoBLL.UsuarioTienePermiso(SessionManager.GetInstance().Usuario.Id, "BTE");
                gESTIONDEUSUARIOSToolStripMenuItem.Visible = permisoBLL.UsuarioTienePermiso(SessionManager.GetInstance().Usuario.Id, "GUS");
                gESTIONDERESERVASToolStripMenuItem.Visible = permisoBLL.UsuarioTienePermiso(SessionManager.GetInstance().Usuario.Id, "GRE");
                gESTIONDEPERFILESToolStripMenuItem.Visible = permisoBLL.UsuarioTienePermiso(SessionManager.GetInstance().Usuario.Id, "GPE");
                gESTIONDEIDIOMASToolStripMenuItem.Visible = permisoBLL.UsuarioTienePermiso(SessionManager.GetInstance().Usuario.Id, "GID");
                bITACORADECAMBIOSToolStripMenuItem.Visible = permisoBLL.UsuarioTienePermiso(SessionManager.GetInstance().Usuario.Id, "BDC");


                bitacoraToolStripMenuItem.Visible = true;
            }
        }

        private void gESTIONDEUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios();
            frmGestionUsuarios.Show();
            this.Hide();
        }

        private void gESTIONDEPERFILESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionPerfiles frmGestionPerfiles = new FrmGestionPerfiles();
            frmGestionPerfiles.Show();
            this.Hide();
        }

        private void gESTIONDEIDIOMASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIdiomas frmIdiomas = new FrmIdiomas();
            frmIdiomas.ShowDialog();
        }

        private BLL_Permisos permisoBLL = new BLL_Permisos();

        private void bITACORADECAMBIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorialCambios frm = new FrmHistorialCambios(
           SessionManager.GetInstance().Usuario.Id,
           SessionManager.GetInstance().Usuario.Username);

            frm.ShowDialog();
        }
      
    }
}
