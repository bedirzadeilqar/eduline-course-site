using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication5
{
    public class sql
    {
        public static DataTable Execute(string sorgu)
        {
            string connectionstring = @"Data Source=DESKTOP-M5BK3NF\SQLEXPRESS;Initial Catalog=Kurs; Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            SqlCommand srg = new SqlCommand(sorgu, sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter(srg);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlcon.Close();
            return dt;
        }

    }
       
}