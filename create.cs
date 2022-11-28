using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    internal class create
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=honeyVM;Initial Catalog=Employee;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("Please Enter Employee Id : ");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Employee First Name : ");
            String EmpFName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Last Name  : ");
            String EmpLname = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Salary : ");
            int EmpSalary = Convert.ToInt32(Console.ReadLine());


            string insertQuery = "insert into Employee(EmpID, EmployeeFirstName, EmployeelastName, Employeesalary) Values('" + EmpId + "','" + EmpFName + "','" + EmpLname + "','" + EmpSalary + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
            sqlConnection.Close();
        }
    }
}
    

