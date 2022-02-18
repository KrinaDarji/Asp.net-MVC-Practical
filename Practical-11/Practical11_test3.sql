  -- create table designation
CREATE TABLE Designation(
   Id integer NOT NULL  identity PRIMARY KEY ,
   Designation varchar(50) not null
   );
   -- create table employee
CREATE TABLE employee_2(
   Id integer NOT NULL  identity PRIMARY KEY ,
   First_Name VARCHAR(50) Not NULL,
   Middle_Name VARCHAR(50) Not NULL,
   Last_Name VARCHAR(50) Not NULL,
   DOB date not null,
   Mobile_Number varchar(10) not null,
   Address_ varchar(100),
   Salary decimal not null,
   DesignationID int 
   constraint fk Foreign key (DesignationID)
   References Designation(ID));

--insert in table designation
INSERT INTO dbo.Designation VALUES('SOFTWARE DEVELOPER');
INSERT INTO dbo.Designation VALUES('QA DEVELOPER');
INSERT INTO dbo.Designation VALUES('LEAD REACT DEVELOPER');
INSERT INTO dbo.Designation VALUES('TEAM MANAGER DEVELOPER');
INSERT INTO dbo.Designation VALUES('PROJECT MANAGER DEVELOPER');

--insert in table employee
INSERT INTO dbo.employee_2 VALUES('KRINA','SUNILKUMAR','DARJI','2001-05-25','6359001722','KHAMBHAT',33000.0,1);
INSERT INTO employee_2 VALUES('SHIVANGI','MAHESHBHAI','LAD','2000-10-10','7600085987','BARODA',50000.0,2);
INSERT INTO employee_2 VALUES('BHAVYESH','SUNILKUMAR','DARJI','2000-10-11','7452369856','AHEMDABAD',20000.0,3); 
INSERT INTO employee_2 VALUES('DHRUV','','DARJI','1998-10-11','7000369856','AHEMDABAD',15000.0,4); 
INSERT INTO employee_2 VALUES('BHAVYA','AKASH','PATEL','2000-12-11','7452000856','AHEMDABAD',25000.0,5); 
--view table data
select * from employee_2;
--view table data 
select * from Designation;
--a query to count the number of records by designation name
SELECT COUNT(Designation) FROM Designation;
--a query to display First Name, Middle Name, Last Name & Designation name
select a.First_Name,a.Middle_Name,a.Last_Name ,b.Designation from employee_2 a , Designation b where b.ID = a.DesignationID ;
--output of a stored procedure to insert data into the Designation table with required parameters
exec dbo.InsertInto ' Senior Software Engineer';
--output of  a stored procedure to insert data into the Employee table with required parameters
exec EMPLOYEE1;
--output of a stored procedure that returns a list of employees with columns Employee Id, First Name, Middle Name, Last Name, Designation, DOB, Mobile Number, Address & Salary (records should be ordered by DOB)
exec EMPLOYEE2;
-- output of a stored procedure that return a list of employees by designation id (Input) with columns Employee Id, First Name, Middle Name, Last Name, DOB, Mobile Number, Address & Salary (records should be ordered by First Name)
exec listofemployee1 1;

--a query to find the employee having maximum salary
select First_Name,Middle_Name,Last_Name from employee_2 where salary =(select  max(Salary) from employee_2);

--a query that displays only those designation names that have more than 1 employee
SELECT D.Designation FROM Designation D WHERE (SELECT COUNT(*) FROM employee_2 E WHERE E.DesignationId = D.id) > 1
--Create Non-Clustered index on the DesignationId column of the Employee table
Create nonclustered index Xdesignation on employee_2([DesignationID] DESC)
execute sp_helpindex  employee_2 ;
--a database view that outputs Employee Id, First Name, Middle Name, Last Name, Designation, DOB, Mobile Number, Address & Salary
SELECT * FROM employee_view ;