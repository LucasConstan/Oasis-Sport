using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class DAL_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.ObtenerConexion();
            cn.Open();

            String query = "select NomUsuario, Contraseña from Usuarios";

            SqlCommand cmd = new SqlCommand(query, cn);
            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Usuario()
                        {
                            Username = reader["NomUsuario"].ToString(),
                            Password = reader["Contraseña"].ToString(),

                        });

                    }
                }
            }
            catch
            {
                System.Console.WriteLine("Error en la busqueda");
            }



            return lista;
        }

    }
}
