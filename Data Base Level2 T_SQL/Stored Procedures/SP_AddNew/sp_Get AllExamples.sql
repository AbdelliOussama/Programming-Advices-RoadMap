CREATE PROCEDURE SP_GetAllBankAccounts
AS
BEGIN
	SELECT * FROM BankAccounts;
END

EXEC SP_GetAllBankAccounts;


CREATE PROCEDURE SP_GetAllCustomers
AS
BEGIN 
	SELECT * FROM Customers;
END

EXEC SP_GetAllCustomers;