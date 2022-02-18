USE Employee;
Go
--Create a stored procedure to insert data into the Designation table with required parameters
CREATE PROCEDURE dbo.InsertInto @Designation varchar(50)
AS
BEGIN;

INSERT INTO dbo.Designation(Designation) values(@Designation);
END;