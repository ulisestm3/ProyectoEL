﻿using DAL;
using EL;

namespace BLL
{
    public class BLL_Clientes
    {
        public static Clientes Insert(Clientes Entidad)
        {
            return DAL_Clientes.Insert(Entidad);
        }
        public static bool Update(Clientes Entidad)
        {
            return DAL_Clientes.Update(Entidad);
        }
        public static bool Anular(Clientes Entidad)
        {
            return DAL_Clientes.Anular(Entidad);
        }
        public static bool Existe(Clientes Entidad)
        {
            return DAL_Clientes.Existe(Entidad);
        }
        public static Clientes Registro(Clientes Entidad)
        {
            return DAL_Clientes.Registro(Entidad);
        }
        public static List<Clientes> Lista(bool Activo = true)
        {
            return DAL_Clientes.Lista(Activo);
        }
        public static bool ValidarNumero(string Numero, int IdRegistro)
        {
            return BLL_Clientes.ValidarNumero(Numero,IdRegistro);
        }

    }
}
