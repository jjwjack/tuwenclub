using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuWen.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TuWen.DAL
{
    public class SqlHelper
    {
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        //查
        public static DataTable GetTable(string sql, CommandType type, params SqlParameter[] ps)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, con))
                {
                    sda.SelectCommand.CommandType = type;
                    if (ps != null)
                    {
                        sda.SelectCommand.Parameters.AddRange(ps);
                    }
                    sda.Fill(dt);
                }
            }
            return dt;
        }
        //增删改
        public static int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] ps)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        
    }
}
