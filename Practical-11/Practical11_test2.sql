-- create table employee
CREATE TABLE employee_1(
   Id integer NOT NULL  identity PRIMARY KEY ,
   First_Name VARCHAR(50) Not NULL,
   Middle_Name VARCHAR(50) Not NULL,
   Last_Name VARCHAR(50) Not NULL,
   DOB date not null,
   Mobile_Number varchar(10) not null,
   Address_ varchar(100),
   Salary decimal not null);
-- insert in table employee
INSERT INTO dbo.employee_1 VALUES('KRINA','SUNILKUMAR','DARJI','2001-05-25','6359001722','KHAMBHAT',33000.0);
INSERT INTO employee_1 VALUES('SHIVANGI','MAHESHBHAI','LAD','2000-10-10','7600085987','BARODA',50000.0);
INSERT INTO employee_1 VALUES('BHAVYESH','SUNILKUMAR','DARJI','2000-10-11','7452369856','AHEMDABAD',20000.0); 
INSERT INTO employee_1 VALUES('DHRUV','','DARJI','1998-10-11','7000369856','AHEMDABAD',15000.0); 
INSERT INTO employee_1 VALUES('BHAVYA','AKASH','PATEL','2000-12-11','7452000856','AHEMDABAD',25000.0); 
--view table data
select * from employee_1;
--an SQL query to find the total amount of salaries
select sum(Salary) from employee_1;
-- an SQL query to find all employees having DOB less than 01-01-2000
select * from employee_1 where DOB < '2000-01-01';
--an SQL query to count employees having Middle Name NULL
select count(Middle_Name) from employee_1 where Middle_Name= null;