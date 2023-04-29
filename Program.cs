namespace EmployeePayroll
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll");
            EmployeeRepo employeeRepo = new EmployeeRepo();
            employeeRepo.AddEmployee();
        }
    }
}