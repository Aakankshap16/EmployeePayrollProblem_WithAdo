namespace EmployeePayroll
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");

            // DATA ACCORDING TO THE GIVEN RANGE UC5
            DateTime startDate = new DateTime(2010, 1, 1);
            DateTime endDate = new DateTime(2022, 12, 31);

            PayrollDBService payrollDBService = new PayrollDBService();
            EmployeeModel employee = payrollDBService.GetEmployeesByJoinDateRange(startDate, endDate);

            if (employee != null)
            {
                Console.WriteLine($"Employee Name: {employee.EmployeeName}");
                Console.WriteLine($"Address: {employee.Address}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Department: {employee.Department}");
                Console.WriteLine($"Start Date: {employee.StartDate}");
                Console.WriteLine($"City: {employee.City}");
                Console.WriteLine($"Country: {employee.Country}");
                Console.WriteLine($"Basic Pay: {employee.BasicPay}");
                Console.WriteLine($"Deduction: {employee.Duduction}");
                Console.WriteLine($"Taxable Pay: {employee.TaxablePay}");
                Console.WriteLine($"Tax: {employee.Tax}");
                Console.WriteLine($"Net Pay: {employee.NetPay}");
            }
            else
            {
                Console.WriteLine("No employees found in the given date range.");
            }

        }
    }
}