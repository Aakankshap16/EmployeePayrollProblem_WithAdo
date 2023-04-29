CREATE PROCEDURE spUpdateEmployeeSalary
(
    @EmployeeName varchar(255),
    @BasicPay float
     
)
AS
BEGIN
    UPDATE employee
    SET  BasicPay = @BasicPay 
    WHERE EmployeeName = @EmployeeName
  
END
drop procedure spUpdateEmployeeSalary

