CREATE PROCEDURE SP_GetStudentByID
	@StudentID INT
AS 
BEGIN 
	SELECT * FROM Students WHERE StudentID = @StudentID;
END

EXEC SP_GetStudentByID
	@StudentID  =1 ;


CREATE PROCEDURE SP_GetOrderInfoByID
	@CustomerName VARCHAR(50),
	@Status VARCHAR(30)
AS
BEGIN
	SELECT * FROM Orders WHERE CustomerName = @CustomerName AND Status = @Status;
END


EXEC SP_GetOrderInfoByID
	@CustomerName = 'Frank',
	@Status = 'Delivered';