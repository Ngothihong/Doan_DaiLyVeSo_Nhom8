using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dai_Ly_Ve_So_1.DAL
{
    class DataAcsess
    {
        //string = "";
        private static SqlConnection GetConnection()
        {
            return new SqlConnection("server=.;database=QLVESO;user=sa;password=Danh123456");
        }
        public static int ExecuteCommand(String query, params SqlParameter[] parameterList)
        {
            int res = 0;
            using (SqlConnection sqlConn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddRange(parameterList);
                sqlConn.Open();

                res = cmd.ExecuteNonQuery();
            }
            return res;
        }
        public static SqlDataReader ExecuteReader(string query, params SqlParameter[] parameterList)
        {
            try
            {
                SqlConnection sqlConn = GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddRange(parameterList);
                sqlConn.Open();
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
