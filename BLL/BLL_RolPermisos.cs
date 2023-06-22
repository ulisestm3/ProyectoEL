using DAL;
using EL;

namespace BLL
{
    public static class BLL_RolPermisos
    {
        public static int Insertar(RolPermisos Entidad)
        {
            return DAL_RolPermisos.Insertar(Entidad);
        }
        public static int Actualizar(RolPermisos Entidad)
        {
            return DAL_RolPermisos.Actualizar(Entidad);
        }
        public static bool Anular(RolPermisos Entidad)
        {
            return DAL_RolPermisos.Anular(Entidad);
        }
    }
}
