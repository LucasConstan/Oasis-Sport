using BLL;
using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oasis_Sports
{
    public partial class FrmGestionUsuarios : BaseForm, IObserverIdioma
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();
            LanguageManager.GetInstance().Agregar(this);
        }

        BLLUsuario bllUsuario = new BLLUsuario();
        ValidadorDeIntegridad Validador = new ValidadorDeIntegridad();

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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtContraseñaRepetida.Text == txtContraseña.Text && txtUsuario.Text != "")
            {
                Usuario usuario = new Usuario();
                usuario.Username = txtUsuario.Text;
                usuario.Password = txtContraseñaRepetida.Text;

                bllUsuario.AñadirUsuario(usuario);
                BLL_Evento bllEvento = new BLL_Evento();

                bllEvento.RegistrarEvento(new Evento()
                {
                    Usuario = SessionManager.GetInstance().Usuario.Username,
                    Modulo = "Usuarios",
                    Descripcion = "Alta de usuario: " + usuario.Username,
                    Fecha = DateTime.Now,
                    Criticidad = 2
                });
                dataGridView1.DataSource = bllUsuario.Listar();

                MessageBox.Show("Usuario añadido correctamente");

                bllUsuario.InicializarDVs();
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

        private int idUsuarioSeleccionado;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado != 0)
            {
                bllUsuario.EliminarUsuario(idUsuarioSeleccionado);

                BLL_Evento bllEvento = new BLL_Evento();

                bllEvento.RegistrarEvento(new Evento()
                {
                    Usuario = SessionManager.GetInstance().Usuario.Username,
                    Modulo = "Usuarios",
                    Descripcion = "Eliminación de usuario",
                    Fecha = DateTime.Now,
                    Criticidad = 3
                });
                dataGridView1.DataSource = bllUsuario.Listar();

                txtUsuario.Clear();
                txtContraseña.Clear();

                MessageBox.Show("El Usuario fue eliminado con exito");
                bllUsuario.InicializarDVs();
                idUsuarioSeleccionado = 0;
            }

            else
            {
                MessageBox.Show("Seleccione un usuario en la grilla");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);

                txtUsuario.Text = fila.Cells["Username"].Value.ToString();
                txtContraseña.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado != 0)
            {
                Usuario usuario = new Usuario()
                {
                    Username = txtUsuario.Text,
                    Password = txtContraseña.Text
                };

                bllUsuario.ModificarUsuario(idUsuarioSeleccionado, usuario);

                BLL_Evento bllEvento = new BLL_Evento();
                bllEvento.RegistrarEvento(new Evento()
                {
                    Usuario = SessionManager.GetInstance().Usuario.Username,
                    Modulo = "Usuarios",
                    Descripcion = "Modificación de usuario: " + usuario.Username,
                    Fecha = DateTime.Now,
                    Criticidad = 2
                });

                dataGridView1.DataSource = bllUsuario.Listar();
                MessageBox.Show("El Usuario fue modificado con éxito");
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtContraseñaRepetida.Clear();

                bllUsuario.InicializarDVs();

                FrmHistorialCambios frm = new FrmHistorialCambios(idUsuarioSeleccionado, usuario.Username);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario en la grilla");
            }
        }

        private void FrmGestionUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            LanguageManager.GetInstance().Quitar(this);

        }
    }
}
