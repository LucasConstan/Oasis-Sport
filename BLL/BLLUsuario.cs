using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class BLLUsuario
    {
        private List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario { Username = "admin", Password = "1234" },
            new Usuario { Username = "user", Password = "1234" }
        };

        
    }
}
