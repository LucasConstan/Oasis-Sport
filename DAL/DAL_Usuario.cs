using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Servicios;

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

            string query = "select NomUsuario, Contraseña from Usuarios";

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

        Encriptacion encriptador = new Encriptacion();

        public void AñadirUsuario(Usuario usuario)
        {
            Conexion conexion = new Conexion();
            SqlConnection cn = conexion.ObtenerConexion();
            cn.Open();

            string query = "INSERT INTO usuarios (nomUsuario, contraseña) VALUES (@NomUsuario, @Contraseña)";

            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                
                cmd.Parameters.AddWithValue("@NomUsuario", usuario.Username);
                cmd.Parameters.AddWithValue("@Contraseña", encriptador.Encriptar(usuario.Password)); 

                
                cmd.ExecuteNonQuery();
            }
        }

    }
}
