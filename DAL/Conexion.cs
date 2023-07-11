using System.Data.SqlClient;

namespace DAL
{
    public static class Conexion
    {
        // Encapsulacion - Accesible solo dentro de la clase
        private static string NombreAplicacion = "GeneradorCapas";
        private static string Servidor = @"LPT-ULISESZ\MSSQLSERVER01";
        private static string Usuario = "";
        private static string Password = "";
        private static string BaseDatos = "MPOO";

        //cadena de caracteres estatica - SqlAutentication = true, false para Windows
        public static string ConexionString(bool SqlAutentication = true)
        {
            SqlConnectionStringBuilder ConstructorCadenaConexion = new SqlConnectionStringBuilder()
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