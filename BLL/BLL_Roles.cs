using DAL;
using EL;
using System.Data;

namespace BLL
{
    public static class BLL_Roles
    {
        public static int Insertar(Roles Entidad)
        {
            return DAL_Roles.Insertar(Entidad);
        }

        public static int Actualizar(Roles Entidad)
        {
            return DAL_Roles.Actualizar(Entidad);
        }
        public static DataTable Select(Roles Entidad)
        {
            return DAL_Roles.Select(Entidad);
        }
        public static bool Anular(Roles Entidad)
        {
            return DAL_Roles.Anular(Entidad);
        }

    }
}
