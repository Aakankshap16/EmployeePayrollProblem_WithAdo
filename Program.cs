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

          //  employeeRepo.AddEmployee(employee);


            EmployeeModel employee2 = new EmployeeModel();
            employee2.EmployeeName = "tersia";
            employee2.PhoneNumber = "9876590";
            employee2.Address = "Main-St";
            employee2.Department = "Sales";
            employee2.Gender = 'F';
            employee2.BasicPay = 200000.00;
            employee2.Duduction = 1500.00;
            employee2.TaxablePay = 200.00;
            employee2.Tax = 1500;
            employee2.NetPay = 1500000.00;
            employee2.StartDate = DateTime.Now;
            employee2.City = "pune";
            employee2.Country = "India";
           

            //employeeRepo.AddEmployee(employee2);

            // Update Terisa's salary
            employeeRepo.UpdateEmployee(employee2.EmployeeName, 3000000.00);


           

        }
    }
}