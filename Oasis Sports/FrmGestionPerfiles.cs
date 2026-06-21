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
    public partial class FrmGestionPerfiles : BaseForm
    {
        public FrmGestionPerfiles()
        {
            InitializeComponent();
        }

        private BLL_Permisos permisoBLL = new BLL_Permisos();
        private BLLUsuario usuarioBLL = new BLLUsuario();





        private void CargarPermisosAsignados(int usuarioId)
        {
            treeView1.Nodes.Clear();

            List<ComponentePermiso> permisos = permisoBLL.ObtenerPermisosUsuario(usuarioId);

            foreach (ComponentePermiso permiso in permisos)
            {
                treeView1.Nodes.Add(CrearNodoPermiso(permiso));
            }

            treeView1.ExpandAll();
        }

        private TreeNode CrearNodoPermiso(ComponentePermiso permiso)
        {
            TreeNode nodo = new TreeNode();

            if (permiso is GrupoPermisos)
                nodo.Text = "[Grupo] " + permiso.Nombre;
            else
                nodo.Text = "[Permiso] " + permiso.Nombre;

            nodo.Tag = permiso;

            foreach (ComponentePermiso hijo in permiso.ObtenerHijos())
            {
                TreeNode nodoHijo = CrearNodoPermiso(hijo);

                nodo.Nodes.Add(nodoHijo);
            }

            return nodo;
        }

        private void CargarUsuarios()
        {
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DisplayMember = "Username";
            cmbUsuarios.ValueMember = "Id";
            cmbUsuarios.DataSource = usuarioBLL.Listar();
        }

        private void CargarLista()
        {
            lstDisponibles.DataSource = null;
            lstDisponibles.DisplayMember = "Nombre";
            lstDisponibles.ValueMember = "Id";
            lstDisponibles.DataSource = permisoBLL.ObtenerTodos();
        }

        private void FrmGestionPerfiles_Load(object sender, EventArgs e)
        {

            CargarUsuarios();
            CargarLista();

        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario usuario = cmbUsuarios.SelectedItem as Usuario;

            if (usuario == null)
                return;

            CargarPermisosAsignados(usuario.Id);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = cmbUsuarios.SelectedItem as Usuario;
            ComponentePermiso permiso = lstDisponibles.SelectedItem as ComponentePermiso;

            if (usuario == null || permiso == null)
            {
                MessageBox.Show("Seleccione un usuario y un permiso");
                return;
            }


            permisoBLL.AsignarPermiso(usuario.Id, permiso.Id);
            CargarPermisosAsignados(usuario.Id);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Usuario usuario = cmbUsuarios.SelectedItem as Usuario;

            if (usuario == null || treeView1.SelectedNode == null)
                return;

            if (treeView1.SelectedNode.Parent != null)
            {
                MessageBox.Show("No se puede quitar un permiso heredado. Debe quitarse el grupo que lo contiene.");
                return;
            }

            ComponentePermiso permiso = treeView1.SelectedNode.Tag as ComponentePermiso;

            if (permiso == null)
            {
                MessageBox.Show("Seleccione un usuario y un permiso");
                return;
            }


            permisoBLL.QuitarPermisoAUsuario(usuario.Id, permiso.Id);

            CargarPermisosAsignados(usuario.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
    }


}
