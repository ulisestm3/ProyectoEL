using System.Data.SqlClient;

namespace DAL
{
    public static class Conexion
    {
        //Credenciales de la Base de Datos
        private static string NombreAplicacion = "GeneradorCapas";
        private static string Servidor = @"LPT-UZUNIGA";
        private static string Usuario = "";
        private static string Password = "";
        private static string BaseDatos = "MPOO";

        //Scrip conexion string a la base de datos cuando es por autenticacion windows dejar en false
        //Si es autenticacion SQL dejar en true
        public static string ConexionString(bool SqlAutentication = false)
        {
            SqlConnectionStringBuilder ConstructorCadenaConexion = new()
            {
                ApplicationName = NombreAplicacion,
                IntegratedSecurity = !SqlAutentication,
                DataSource = Servidor,
                InitialCatalog = BaseDatos
            };
            if (SqlAutentication)
            {
                ConstructorCadenaConexion.UserID = Usuario;
                ConstructorCadenaConexion.Password = Password;
            }
            return ConstructorCadenaConexion.ConnectionString;
        }
    }
}