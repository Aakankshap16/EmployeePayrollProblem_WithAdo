using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll;

namespace EmployeePayroll.Tests
{
    [TestClass]
    public class PayrollDBServiceTests
    {
        [TestMethod]
        public void TestGetEmployeeNameByName()
        {
            // Arrange
            PayrollDBService payrollDBService = new PayrollDBService();
            string employeeName = "Divya";

            // Act
            EmployeeModel result = payrollDBService.GetEmployeeNameByName(employeeName);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(employeeName, result.EmployeeName);
        }
    }
}
