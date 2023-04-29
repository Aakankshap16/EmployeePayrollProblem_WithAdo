namespace EmployeePayroll
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");
            EmployeeRepo employeeRepo = new EmployeeRepo();

            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeName = "Aakanksha Pandey";
            employee.PhoneNumber = "234567890";
            employee.Address = "sector-7";
            employee.Department = "Hr";
            employee.Gender = 'F';
            employee.BasicPay = 200000.00;
            employee.Duduction = 1500.00;
            employee.TaxablePay = 200.00;
            employee.Tax = 300;
            employee.NetPay = 2500.00;
            employee.StartDate = DateTime.Now;
            employee.City = "Hydrabad";
            employee.Country = "India";


            employeeRepo.AddEmployee(employee);

        }
    }
}