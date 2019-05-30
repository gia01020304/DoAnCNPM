using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DAO
{
    public class DataAccess
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["QuanLyHoaDonConnectionString"].ConnectionString;
        private static SqlConnection conn = new SqlConnection(connectionString);
        private static Exception errorDB;

        static private SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        static public DataTable ExcuteQuery(string Query, SqlParameter[] Par = null)
        {
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Query, OpenConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (Par != null)
                {
                    cmd.Parameters.AddRange(Par);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (System.Exception ex)
            {
                errorDB = ex;
                return null;
            }
            finally
            {
                conn.Close();
            }

            return table;
        }

        static public int ExcuteNonQuery(string query, SqlParameter[] par)
        {
            int kq = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, OpenConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddRange(par);
                kq = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                errorDB = ex;
            }
            finally
            {
                conn.Close();
            }
            return kq;
        }
    }
}
