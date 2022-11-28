using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal class Retrieve
    {
        public static void Main(string[] args)
        {
            string connectionString = " data source =.;Database=honeyVM; integrated security = 'True'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM student";


                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string stid = dr["stid"].ToString();
                        string stname = dr["stname"].ToString();
                        string stgroup = dr["stgroup"].ToString();

                        Console.WriteLine(stid + "  " + stname + "  " + stgroup);
                    }
                    dr.Close();

                }
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
