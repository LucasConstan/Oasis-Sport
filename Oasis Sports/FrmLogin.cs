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
    public partial class FrmLogin : BaseForm
    {
        BLLUsuario bllUsuario = new BLLUsuario();
        public FrmLogin()
        {
            InitializeComponent();
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

            String NomUsuario = textBox1.Text;
            String Contraseña = textBox2.Text;

            Usuario user = bllUsuario.Listar().FirstOrDefault(u => u.Username == NomUsuario);


            if (user != null && user.Password == encriptador.Encriptar(Contraseña))
            {
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

                MessageBox.Show("Bienvenido " + NomUsuario);

                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();
            }
            else
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

                //MessageBox.Show(" Las contraseñas son " + user.Password + " y " + Contraseña);
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            textBox2.Text = "1234";
            textBox1.Text = "ferni";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
