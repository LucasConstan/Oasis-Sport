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


            if (user != null && user.Password == Contraseña)
            {
                SessionManager.GetInstance().Login(user);

                MessageBox.Show("Bienvenido " + NomUsuario);

                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            textBox2.Text = "1234";
           
        }
    }
}
