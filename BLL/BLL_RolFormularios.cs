using DAL;
using EL;

namespace BLL
{
    public static class BLL_RolFormularios
    {
        public static RolFormularios Insert(RolFormularios Entidad)
        {
            return DAL_RolFormularios.Insert(Entidad);
        }

        public static bool Update(RolFormularios Entidad)
        {
            return DAL_RolFormularios.Update(Entidad);
        }

        public static bool Existe(RolFormularios Entidad)
        {
            return DAL_RolFormulariosExiste.Existe(Entidad);
        }

        public static RolFormularios Registro(RolFormularios Entidad)
        {
            return DAL_RolFormularios.Registro(Entidad);
        }

        public static List<RolFormularios> Lista(bool Activo = true)
        {
            return DAL_RolFormularios.Lista(Activo);
        }
    }
}
