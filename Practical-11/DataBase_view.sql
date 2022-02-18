use Employee;
GO
--a database view that outputs Employee Id, First Name, Middle Name, Last Name, Designation, DOB, Mobile Number, Address & Salary
CREATE VIEW  employee_view 
as
select a.First_Name,a.Middle_Name,a.Last_Name ,b.Designation, a.Salary,a.DOB,a.Mobile_Number,a.Address_ from  employee_2 a , Designation b where b.ID = a.DesignationID;
