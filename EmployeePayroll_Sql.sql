  
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

insert into employee values('Divya','9876543','Sector-5','Software','F',1000,300,500,1200,2500,'2019-5-16','Lucknow','India')
insert into employee values('Shivam','98567987','Block-8','Software','M',1000,300,500,1200,2500,'2019-5-16','Bhopal','India')
insert into employee values('terisa','9876543','Sector-5','Software','F',1000,300,500,1200,2500,'2010-9-10','Goa','India')




