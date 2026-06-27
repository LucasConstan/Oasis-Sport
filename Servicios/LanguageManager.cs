using Entidades;
using Microsoft.Data.SqlClient;

namespace Servicios
{
    public class LanguageManager
    {
        
        private static LanguageManager? instancia;
        private static readonly object candado = new object();

        private LanguageManager() { }

        public static LanguageManager GetInstance()
        {
            lock (candado)
            {
                if (instancia == null)
                    instancia = new LanguageManager();
                return instancia;
            }
        }

    
        private static string cadenaConexion =
            "Data Source=.;" +
            "Initial Catalog=OasisSports;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        
        private int idIdiomaActual = 1;
        private List<Traduccion> traducciones = new List<Traduccion>();
        private List<IObserverIdioma> observadores = new List<IObserverIdioma>();

        public int IdIdiomaActual => idIdiomaActual;

        public void Agregar(IObserverIdioma observador)
        {
            if (!observadores.Contains(observador))
                observadores.Add(observador);
        }

        public void Quitar(IObserverIdioma observador)
        {
            observadores.Remove(observador);
        }

        private void Notificar()
        {
            foreach (var obs in observadores.ToList())
                obs.ActualizarIdioma();
        }

        public void CambiarIdioma(int idIdioma)
        {
            idIdiomaActual = idIdioma;
            CargarTraducciones();
            Notificar();
        }

        private void CargarTraducciones()
        {
            traducciones = new List<Traduccion>();

            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    string query = "SELECT IdTraduccion, IdIdioma, Clave, Texto FROM Traduccion WHERE IdIdioma = @IdIdioma";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@IdIdioma", idIdiomaActual);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            traducciones.Add(new Traduccion
                            {
                                IdTraduccion = (int)reader["IdTraduccion"],
                                IdIdioma     = (int)reader["IdIdioma"],
                                Clave        = reader["Clave"].ToString()!,
                                Texto        = reader["Texto"].ToString()!
                            });
                        }
                    }
                }
            }
            catch
            {
                
            }
        }

        // ── Obtener texto por clave ────────────────────────────────────────────
        public string ObtenerTexto(string clave)
        {
            if (traducciones.Count == 0)
                CargarTraducciones();

            var t = traducciones.FirstOrDefault(x => x.Clave == clave);
            return t != null ? t.Texto : clave;
        }

        
        public void TraducirControles(object formulario)
        {
            if (formulario is System.Windows.Forms.Control ctrl)
                TraducirRecursivo(ctrl.Controls);
        }

        private void TraducirRecursivo(System.Windows.Forms.Control.ControlCollection controles)
        {
            foreach (System.Windows.Forms.Control c in controles)
            {
                string texto = ObtenerTexto(c.Name);
                if (texto != c.Name)
                    c.Text = texto;

                if (c.Controls.Count > 0)
                    TraducirRecursivo(c.Controls);

                if (c is System.Windows.Forms.MenuStrip ms)
                    TraducirMenuItems(ms.Items);

                if (c is System.Windows.Forms.ToolStrip ts)
                    TraducirMenuItems(ts.Items);
            }
        }

        private void TraducirMenuItems(System.Windows.Forms.ToolStripItemCollection items)
        {
            foreach (System.Windows.Forms.ToolStripItem item in items)
            {
                string texto = ObtenerTexto(item.Name);
                if (texto != item.Name)
                    item.Text = texto;

                if (item is System.Windows.Forms.ToolStripMenuItem mi && mi.DropDownItems.Count > 0)
                    TraducirMenuItems(mi.DropDownItems);
            }
        }
    }
}
