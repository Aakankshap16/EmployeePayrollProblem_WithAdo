using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace EmployeePayroll
{
   
    public class PayrollDBService
    {
        private static readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PayRollService266;Integrated Security=True";
        private static PayrollDBService instance = null;
        private static SqlConnection connection = null;
        private static SqlCommand getEmployeeModelByNameCommand = null;

        private PayrollDBService()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            getEmployeeModelByNameCommand = new SqlCommand("SELECT * FROM employee WHERE EmployeeName = @EmployeeName", connection);
            getEmployeeModelByNameCommand.Parameters.AddWithValue("@EmployeeName", " ");
        }

        public static PayrollDBService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PayrollDBService();
                }
                return instance;
            }
        }

        public EmployeeModel GetEmployeeNameByName(string name)
        {
            EmployeeModel employee =new EmployeeModel();
            getEmployeeModelByNameCommand.Parameters["@EmployeeName"].Value = name;
            SqlDataReader reader = getEmployeeModelByNameCommand.ExecuteReader();
            if (reader.Read())
            {
                employee = new EmployeeModel();
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.BasicPay = Convert.ToInt32(reader["BasicPay"]);
                employee.StartDate = Convert.ToDateTime(reader["StartDate"]);
            }
            reader.Close();
           return employee;
        }
    }

}
