using DAL;
using EL;

namespace BLL
{
    public static class BLL_RolFormularios
    {
        public static int Insertar(RolFormularios Entidad)
        {
            return DAL_RolFormularios.Insertar(Entidad);
        }
        public static int Actualizar(RolFormularios Entidad)
        {
            return DAL_RolFormularios.Actualizar(Entidad);
        }

        public static bool Anular(RolFormularios Entidad)
        {
            return DAL_RolFormularios.Anular(Entidad);
        }
    }
}
