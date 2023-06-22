using System.Data.SqlClient;
using EL;
using System.Data;

namespace DAL
{
    public static class DAL_RolFormularios
    {
        public static int Insertar(RolFormularios Entidad)
        {
            SqlConnection sqlConnection = new SqlConnection(Conexion.ConexionString());
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("InsertarRolFormulario", sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdRolFormulario", Entidad.IdRolFormulario);
            cmd.Parameters.AddWithValue("@IdRol", Entidad.IdRol);
            cmd.Parameters.AddWithValue("@IdFormulario", Entidad.IdFormulario);
            cmd.Parameters.AddWithValue("@IdUsuarioRegistra", Entidad.IdUsuarioRegistra);
            int ID = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();
            sqlConnection.Dispose();
            return ID;
        }

        public static int Actualizar(RolFormularios Entidad)
        {
            SqlConnection sqlConnection = new SqlConnection(Conexion.ConexionString());
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("ActualizarRolFormulario", sqlConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdRolFormulario", Entidad.IdRolFormulario);
            cmd.Parameters.AddWithValue("@IdRol", Entidad.IdRol);
            cmd.Parameters.AddWithValue("@IdFormulario", Entidad.IdFormulario);
            cmd.Parameters.AddWithValue("@IdUsuarioActualiza", Entidad.IdUsuarioActualiza);
            int ID = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();
            sqlConnection.Dispose();
            return ID;
        }

        public static bool Anular(RolFormularios Entidad)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Conexion.ConexionString());
                sqlConnection.Open();
                SqlCommand Cmd = new SqlCommand("AnularRolFormulario", sqlConnection);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdRolFormulario", Entidad.IdRolFormulario);
                Cmd.Parameters.AddWithValue("@IdUsuarioActualizar", Entidad.IdUsuarioActualiza);
                Cmd.ExecuteNonQuery();
                sqlConnection.Close();
                sqlConnection.Dispose();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}