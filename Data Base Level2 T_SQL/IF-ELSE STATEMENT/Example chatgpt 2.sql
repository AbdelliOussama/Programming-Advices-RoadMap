CREATE TABLE Customers
(CustomerID INT IDENTITY(1,1) PRIMARY KEY,
CustomerName NVARCHAR(20) NOT NULL,
CustomerEmail NVARCHAR(30) NOT NULL
);

INSERT INTO Customers
(CustomerName,CustomerEmail)
Values
('Oussama','Oussama.abdelli@gmail.com'),
('Salim','salimab99@gmail.com');

SELECT * FROM Customers;

DECLARE @CustomerID INT = 1; 
DECLARE @NewEmail  VARCHAR(30)='oussama.abdelli@etudiant-istmt.utm.tn' ;
IF EXISTS (SELECT * FROM Customers WHERE CustomerID  = @CustomerID)
	BEGIN 
		UPDATE Customers 
		SET CustomerEmail = @NewEmail
		WHERE CustomerID = @CustomerID
	END
ELSE
	BEGIN 
		PRINT 'Customer Not Found';
	END

INSERT INTO Customers
(CustomerName,CustomerEmail)
Values('Oussama','Ouss@yahoo.fr');
DECLARE @ErrorNumber  int = @@ERROR ;
IF @ErrorNumber <>0
	BEGIN 
		PRINT 'An Error Occured With Error Number = '+CAST(@ErrorNumber AS VARCHAR);
	END
ELSE
	BEGIN 
		PRINT 'Customer Added Succefully';
	END