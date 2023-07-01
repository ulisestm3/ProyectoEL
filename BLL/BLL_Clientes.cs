using DAL;
using EL;

namespace BLL
{
    public static class BLL_Clientes
    {
        public static Clientes Insert(Clientes Entidad)
        {
            return DAL_Clientes.Insert(Entidad);
        }
        public static bool Update(Clientes Entidad)
        {
            return DAL_Clientes.Update(Entidad);
        }
        public static bool Delete(Clientes Entidad)
        {
            return DAL_Clientes.Delete(Entidad);
        }
        public static Clientes Registro(short IdRegistro)
        {
            return DAL_Clientes.Registro(IdRegistro);
        }
        public static List<Clientes> Listar(bool Activo = true)
        {
            return DAL_Clientes.Listar(Activo);
        }

    }
}
