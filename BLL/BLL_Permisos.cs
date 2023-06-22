using DAL;
using EL;
using System.Data;

namespace BLL
{
    public static class BLL_Permisos
    {
        public static int Insertar(Permisos Entidad)
        {
            return DAL_Permisos.Insertar(Entidad);
        }

        public static int Actualizar(Permisos Entidad)
        {
            return DAL_Permisos.Actualizar(Entidad);
        }
        public static DataTable Select(Permisos Entidad)
        {
            return DAL_Permisos.Select(Entidad);
        }
        public static bool Anular(Permisos Entidad)
        {
            return DAL_Permisos.Anular(Entidad);
        }
    }
}
