﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal class Delete
    {
        static void Main(string[] args)
        {

            SqlConnection con;
            string connectionString = " data source =.;Database=honeyVM; integrated security = 'True'";
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                Console.WriteLine("connection established successfully");
                Console.WriteLine();
                Console.WriteLine("Enter the id that is to be deleted");
                int id = Convert.ToInt32(Console.ReadLine());
                string deleteQuery = "DELETE from student WHERE stid = " + id + "";
                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Deleted successfully");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
