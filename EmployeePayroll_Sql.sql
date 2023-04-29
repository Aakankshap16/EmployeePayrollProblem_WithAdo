  
    /* Welcome to EmployeePayRoll in sql */
create table employee
(
EmployeeId int primary key identity,
EmployeeName varchar(355),
PhoneNumber varchar(255),
Address  varchar(255),
Department varchar(255),
Gender varchar(255),
BasicPay float,
Duduction float,
TaxablePay float,
Tax float,
NetPay float,
StartDate Date,
City varchar(255),
Country varchar(255)
)

select * from employee


