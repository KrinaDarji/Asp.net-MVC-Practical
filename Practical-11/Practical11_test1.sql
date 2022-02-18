EXEC sp_columns employee;
--insert in table employee
INSERT INTO dbo.employee VALUES(1,'KRINA','SUNILKUMAR','DARJI','2001-05-25','6359001722','KHAMBHAT');
INSERT INTO employee VALUES(2,'SHIVANGI','MAHESHBHAI','LAD','2000-10-10','7600085987','BARODA');
INSERT INTO employee VALUES(3,'BHAVYESH','SUNILKUMAR','DARJI','2000-10-11','7452369856','AHEMDABAD'); 
INSERT INTO employee VALUES(4,'DHRUV','','DARJI','1998-10-11','7000369856','AHEMDABAD'); 
INSERT INTO employee VALUES(5,'BHAVYA','AKASH','PATEL','2000-12-11','7452000856','AHEMDABAD'); 
--view table employee
select * from employee;
--an Update query to change the First Name to “SQLPerson” for the first record
update employee set [First Name]='SQLPerson' where Id=1;

select * from employee;
--an Update query to change the Middle Name to “I” for all records
update employee set [Middle Name]='I';
--delete query to delete record having Id column value less than 2
delete from employee where Id<2;
--delete all the data from the table
delete from employee;