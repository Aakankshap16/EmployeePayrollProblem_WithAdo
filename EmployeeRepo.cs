using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class EmployeeRepo
    {
        public static string connectionstring = "data source=(localdb)\\MSSQLLocalDB; initial catalog=PayRollService266; integrated security=true";

        SqlConnection connection = new SqlConnection(connectionstring);

        public bool AddEmployee()
        {
            try
            {
                using (this.connection)
                {
                    connection.Open();
                    Console.WriteLine("Database connection established.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }

            finally
            {
                this.connection.Close();
            }
            return false;
        }

    }
}
