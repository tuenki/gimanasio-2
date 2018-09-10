using System.Data.SqlClient;
using System.Data;

namespace GYMDatos
{
    class DBConexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=tcp:novato.database.windows.net,1433;Initial Catalog=xtremegym;Persist Security Info=False;User ID=gym;Password=helado@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if(Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
