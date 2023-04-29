using EmployeePayroll;
namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUpdateEmployee()
        {
            EmployeeRepo repo = new EmployeeRepo();
            string employeeName = "Terisa";
            double newBasicPay = 3000000.00;

            bool result = repo.UpdateEmployee(employeeName, newBasicPay);

            Assert.IsTrue(result);
        }
    }
}