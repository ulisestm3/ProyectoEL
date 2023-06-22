using DAL;
using EL;
using System.Data;

namespace BLL
{
    public static class BLL_Formularios
    {
        public static int Insertar(Formularios Entidad)
        {
            return DAL_Formularios.Insertar(Entidad);
        }

        public static int Actualizar(Formularios Entidad)
        {
            return DAL_Formularios.Actualizar(Entidad);
        }
        public static DataTable Select(Formularios Entidad)
        {
            return DAL_Formularios.Select(Entidad);
        }
        public static bool Anular(Formularios Entidad)
        {
            return DAL_Formularios.Anular(Entidad);
        }
    }
}
