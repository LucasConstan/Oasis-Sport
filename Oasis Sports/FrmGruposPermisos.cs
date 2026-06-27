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
    public partial class FrmGruposPermisos : BaseForm
    {
        public FrmGruposPermisos()
        {
            InitializeComponent();
        }

        private BLL_Permisos permisoBLL = new BLL_Permisos();
        private List<ComponentePermiso> permisosSeleccionados = new List<ComponentePermiso>();

        private void FrmGruposPermisos_Load(object sender, EventArgs e)
        {
            CargarPermisosDisponibles();
        }

        private void CargarPermisosDisponibles()
        {
            lstPermisosDisponibles.DataSource = null;
            lstPermisosDisponibles.DataSource = permisoBLL.ObtenerTodos();
            lstPermisosDisponibles.DisplayMember = "Nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ComponentePermiso permiso = lstPermisosDisponibles.SelectedItem as ComponentePermiso;

            if (permiso == null)
                return;

            if (permisosSeleccionados.Any(p => p.Id == permiso.Id))
            {
                MessageBox.Show("Ese permiso ya fue agregado al grupo.");
                return;
            }

            permisosSeleccionados.Add(permiso);
            RefrescarPermisosDelGrupo();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ComponentePermiso permiso = lstPermisosDelGrupo.SelectedItem as ComponentePermiso;

            if (permiso == null)
                return;

            permisosSeleccionados.Remove(permiso);
            RefrescarPermisosDelGrupo();
        }

        private void RefrescarPermisosDelGrupo()
        {
            lstPermisosDelGrupo.DataSource = null;
            lstPermisosDelGrupo.DataSource = permisosSeleccionados.ToList();
            lstPermisosDelGrupo.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreGrupo = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreGrupo))
            {
                MessageBox.Show("Debe ingresar un nombre para el grupo.");
                return;
            }

            if (permisosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un permiso al grupo.");
                return;
            }

            int grupoId = permisoBLL.CrearGrupoPermiso(nombreGrupo);

            foreach (ComponentePermiso permiso in permisosSeleccionados)
            {
                permisoBLL.AgregarPermisoAGrupo(grupoId, permiso.Id);
            }

            MessageBox.Show("Grupo de permisos creado correctamente.");

            textBox1.Clear();
            permisosSeleccionados.Clear();
            RefrescarPermisosDelGrupo();
            CargarPermisosDisponibles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGestionPerfiles frmGestionPerfiles = new FrmGestionPerfiles();
            frmGestionPerfiles.Show();
            this.Hide();
        }
    }
}
