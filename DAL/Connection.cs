using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class Connection
    {
        private static SqlConnection conn;

        public static void connect()
        {
            string s = "initial catalog = ThueXe; data source = KUTEN-PC; integrated security = true";
            conn = new SqlConnection(s);
            conn.Open();
        }

        public static bool actionQuery(string sql)
        {
            connect();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }
            }
        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
    }
}
