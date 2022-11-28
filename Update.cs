using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal class Update
    {
        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=honeyVM;Initial Catalog=Employee;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("Please Enter updated Employee Id : ");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter updated Employee First Name : ");
            String EmpFName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter updated Employee Last Name  : ");
            String EmpLname = Console.ReadLine();

            Console.WriteLine("\nPlease Enter updated Employee Salary : ");
            int EmpSalary = Convert.ToInt32(Console.ReadLine());


            string updateQuery = "Update Employee_tb1 set  Firstname  =  '" + EmpFName + "', Lastname='" + EmpLname + "', Salary='" + EmpSalary + "'WHERE  EmpID = " + EmpId + "";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("\nData Updated");
            sqlConnection.Close();
        }
    }
}
    

