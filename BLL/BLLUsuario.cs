using Entidades;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    public class BLLUsuario
    {
        public DAL_Usuario DAL_Usuario = new DAL_Usuario();

        public List<Usuario> Listar()
        {
            return DAL_Usuario.Listar();
        }

        public void AñadirUsuario(Usuario usuario)
        {
            DAL_Usuario.AñadirUsuario(usuario);
        }

        public void ModificarUsuario(int idUsuario, Usuario usuario)
        {
            DAL_Usuario.ModificarUsuario(idUsuario, usuario);
        }

        public void EliminarUsuario(int idUsuario)
        {
            DAL_Usuario.EliminarUsuario(idUsuario);
        }

    }
}
