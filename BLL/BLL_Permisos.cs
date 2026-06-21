using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Servicios;

namespace BLL
{
    public class BLL_Permisos
    {
        private  DAL_Permisos permisoDAL = new DAL_Permisos();




        public bool UsuarioTienePermiso(int usuarioId, string codigoPermiso)
        {
            List<ComponentePermiso> permisos = permisoDAL.ObtenerPermisosDeUsuario(usuarioId);

            foreach (ComponentePermiso permiso in permisos)
            {
                if (permiso.TienePermiso(codigoPermiso))
                    return true;
            }

            return false;
        }

        public List<ComponentePermiso> ObtenerPermisosUsuario(int usuarioId)
        {
            return permisoDAL.ObtenerPermisosDeUsuario(usuarioId);
        }

        public bool TienePermiso(string codigoPermiso, int usuarioId)
        {
            if (SessionManager.GetInstance().Usuario == null)
                return false;

            List<ComponentePermiso> permisos = permisoDAL.ObtenerPermisosDeUsuario(usuarioId);

            foreach (ComponentePermiso permiso in permisos)
            {
                if (permiso.TienePermiso(codigoPermiso))
                    return true;
            }

            return false;
        }

        public void AsignarPermiso(int usuarioId, int permisoId)
        {
            permisoDAL.AsignarPermiso(usuarioId, permisoId);
        }

        public void QuitarPermisoAUsuario(int usuarioId, int permisoId)
        {
            permisoDAL.QuitarPermiso(usuarioId, permisoId);
        }

        public List<ComponentePermiso> ObtenerTodos()
        {
            return permisoDAL.ObtenerTodos();
        }

       
    }
}
