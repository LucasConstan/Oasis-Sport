using DAL;
using Entidades;

namespace BLL
{
    public class BLL_Traduccion
    {
        DAL_Traduccion dal = new DAL_Traduccion();

        public List<Traduccion> ObtenerPorIdioma(int idIdioma)
        {
            return dal.ObtenerPorIdioma(idIdioma);
        }

        public List<string> ObtenerTodasLasClaves()
        {
            return dal.ObtenerTodasLasClaves();
        }

        public void GuardarOActualizar(Traduccion traduccion)
        {
            dal.GuardarOActualizar(traduccion);
        }
    }
}
