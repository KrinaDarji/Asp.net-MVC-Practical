USE Employee;
go
--Create a stored procedure to insert data into the Employee table with required parameters
CREATE PROCEDURE EMPLOYEE1
AS 
insert into employee_2 values('Dhwani','tejas','shah','2000-07-07','8000025961','Khambhat',33320.0,6)
go
--a stored procedure that returns a list of employees with columns Employee Id, First Name, Middle Name, Last Name, Designation, DOB, Mobile Number, Address & Salary (records should be ordered by DOB)
CREATE PROCEDURE EMPLOYEE2
AS
select a.First_Name,a.Middle_Name,a.Last_Name ,b.Designation, a.Salary,a.DOB,a.Mobile_Number,a.Address_ from  employee_2 a , Designation b where b.ID = a.DesignationID order by DOB;
GO
-- a stored procedure that return a list of employees by designation id (Input) with columns Employee Id, First Name, Middle Name, Last Name, DOB, Mobile Number, Address & Salary (records should be ordered by First Name)
CREATE PROCEDURE listofemployee1(@id int)
AS
select a.First_Name,a.Middle_Name,a.Last_Name ,b.Designation, a.Salary,a.DOB,a.Mobile_Number,a.Address_ from  employee_2 a , Designation b where b.ID = a.DesignationID and a.DesignationID =@id order by First_Name;
GO
Drop procedure dbo.listofemployee1;
go