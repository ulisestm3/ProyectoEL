using EL;
using System.Data;

namespace DAL
{
    public static class DAL_Clientes
    {
        //Insertar
        public static Clientes Insert(Clientes Entidad)
        {
            using (BDMPOO bd = new())
            {
                Entidad.Activo = true;
                Entidad.FechaRegistro = DateTime.Now;
                bd.Clientes.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }
           

        //Actualizar
        public static bool Update(Clientes Entidad)
        {
            using BDMPOO bd = new();
            var Registro = bd.Clientes.Find(Entidad.IdCliente);
            if (Registro == null)
            {
                return false;
            }
                        
            Registro.NombreCliente = Entidad.NombreCliente;
            Registro.Correo = Entidad.Correo;
            Registro.Numero = Entidad.Numero;

            Registro.IdUsuarioActualiza = Entidad.IdUsuarioActualiza;
            Registro.FechaActualizacion = DateTime.Now;
            return bd.SaveChanges() > 0;
        }

        //Anular
        public static bool Delete(Clientes Entidad)
        {
            using BDMPOO bd = new();
            var Registro = bd.Clientes.Find(Entidad.IdCliente);
            if (Registro == null)
            {
                return false;
            }

            Registro.Activo = false;
            Registro.FechaActualizacion = DateTime.Now;
            return bd.SaveChanges() > 0;
        }
        //Seleccionar un registro
        public static Clientes Registro(short IdRegistro)
        {
            using BDMPOO bd = new();
            return bd.Clientes.Find(IdRegistro);
        }

        //Listar todos los registros
        public static List<Clientes> Listar(bool Activo = true)
        {
            using BDMPOO bd = new();
            {
                return bd.Clientes.Where(a => a.Activo == Activo).ToList();
            }            
        }
    }
}
