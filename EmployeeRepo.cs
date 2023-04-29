using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class EmployeeRepo
    {
        private static SqlConnection ConnectionString()
        {
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PayRollService266;Integrated Security=True");
        }

       

        public bool AddEmployee(EmployeeModel model)
        {
            SqlConnection connection = ConnectionString();
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("SpAddemployeeDetails", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@Department", model.Department);
                    command.Parameters.AddWithValue("@Gender", model.Gender);
                    command.Parameters.AddWithValue("@BasicPay ", model.BasicPay);
                    command.Parameters.AddWithValue("@Duduction", model.Duduction);
                    command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    command.Parameters.AddWithValue("@Tax", model.Tax);
                    command.Parameters.AddWithValue("@NetPay", model.NetPay);
                    command.Parameters.AddWithValue("@StartDate", model.StartDate);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@Country", model.Country);

                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return false;
        }

     
        // FOR UPDATE
        public bool UpdateEmployee(string employeeName, double newBasicPay)
        {
            SqlConnection salaryconnection = ConnectionString();
            try
            {
                using (salaryconnection)
                {
                    SqlCommand command = new SqlCommand("spUpdateEmployeeSalary", salaryconnection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BasicPay", newBasicPay);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);

                    salaryconnection.Open();
                    var result = command.ExecuteNonQuery();
                    salaryconnection.Close();
                    if (result != 0)
                    {
                        // Update the EmployeeModel object with the updated BasicPay
                        EmployeeModel employee = new EmployeeModel();
                        employee.BasicPay = newBasicPay;
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }

            finally
            {
                salaryconnection.Close();
            }
            return false;
        }


    }
}
