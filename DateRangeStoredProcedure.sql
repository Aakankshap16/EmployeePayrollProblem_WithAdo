create procedure spGetEmployeesByJoiningDateRange
(
 @GivenStartDate Date,
 @EndDate Date
)
as
begin
  SELECT EmployeeName, Address, PhoneNumber, Department, StartDate, City, Country, BasicPay, Duduction, TaxablePay, Tax, NetPay
   from employee where StartDate >= @GivenStartDate and StartDate <=  @EndDate 
end
