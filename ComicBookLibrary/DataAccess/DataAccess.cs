
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public static class DataAccess
    {
        public static string connectionString { private get; set; }


        internal static DataTable GetDataTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }


        internal static DataSet GetDataSet(SqlCommand cmd)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }

            return ds;
        }

        internal static object GetValue(SqlCommand cmd)
        {
            object returnValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;

                conn.Open();
                returnValue = cmd.ExecuteScalar();
                conn.Close();
            }

            return returnValue;
        }

        internal static int ExecuteNonQuery(SqlCommand cmd)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;

                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return rowsAffected;
        }

        internal static object ExecuteScalar(SqlCommand cmd)
        {
            object returnValue;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                conn.Open();
                returnValue = cmd.ExecuteScalar();
                conn.Close();
            }
            return returnValue;
        }
    }
}
