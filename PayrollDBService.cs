﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace EmployeePayroll
{
   
    public class PayrollDBService
    {
        private static SqlConnection ConnectionString()
        {
            return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PayRollService266;Integrated Security=True");
        }
        public EmployeeModel GetEmployeeNameByName(string name)
        {
            EmployeeModel employee = null;

            using (SqlConnection conn = ConnectionString())
            {
                try
                {
                    using (SqlCommand getEmployeeModelByNameCommand = new SqlCommand("SELECT * FROM employee WHERE EmployeeName = @EmployeeName", conn))
                    {
                        getEmployeeModelByNameCommand.Parameters.AddWithValue("@EmployeeName", " ");
                        employee = new EmployeeModel();
                        conn.Open();
                        getEmployeeModelByNameCommand.Parameters["@EmployeeName"].Value = name;
                        SqlDataReader reader = getEmployeeModelByNameCommand.ExecuteReader();
                      
                        if (reader.Read())
                        {
                            employee.EmployeeName = reader["EmployeeName"].ToString();
                            employee.BasicPay = Convert.ToInt32(reader["BasicPay"]);
                            employee.StartDate = Convert.ToDateTime(reader["StartDate"]);
                        }
                        reader.Close();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to database: " + ex.Message);
                }
            }

            return employee;
        }


    }
}


