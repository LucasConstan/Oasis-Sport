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
    public partial class FrmLogin : BaseForm, IObserverIdioma
    {
        BLLUsuario bllUsuario = new BLLUsuario();

        public FrmLogin()
        {
            InitializeComponent();
            LanguageManager.GetInstance().Agregar(this);
        }


        public void ActualizarIdioma()
        {

            if (this.InvokeRequired)
                this.Invoke(new Action(() => LanguageManager.GetInstance().TraducirControles(this)));
            else
                LanguageManager.GetInstance().TraducirControles(this);
        }


        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
                ActualizarIdioma();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            LanguageManager.GetInstance().Quitar(this);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        Encriptacion encriptador = new Encriptacion();

        private void button1_Click(object sender, EventArgs e)
        {
            if (SessionManager.GetInstance().IsLogged())
            {
                MessageBox.Show("Ya hay una sesión activa");
                return;
            }

            try
            {
                Usuario user = bllUsuario.ValidarUsuario(textBox1.Text, textBox2.Text);

                SessionManager.GetInstance().Login(user);

                BLL_Evento bllEvento = new BLL_Evento();

                bllEvento.RegistrarEvento(new Evento()
                {
                    Usuario = user.Username,
                    Modulo = "Login",
                    Descripcion = "Inicio de sesión",
                    Fecha = DateTime.Now,
                    Criticidad = 1
                });

                MessageBox.Show("Bienvenido " + user.Username);

                FrmSeleccionIdioma frmIdioma = new FrmSeleccionIdioma();
                frmIdioma.ShowDialog(); // espera a que se cierre

                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                BLL_Evento bllEvento = new BLL_Evento();

                bllEvento.RegistrarEvento(new Evento()
                {
                    Usuario = textBox1.Text,
                    Modulo = "Login",
                    Descripcion = "Intento fallido",
                    Fecha = DateTime.Now,
                    Criticidad = 3
                });

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            textBox2.Text = "123";
            textBox1.Text = "jondem";
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void FrmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            LanguageManager.GetInstance().Quitar(this);
        }
    }
}
