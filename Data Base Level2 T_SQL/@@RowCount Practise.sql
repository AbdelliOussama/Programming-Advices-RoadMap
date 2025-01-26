--UPDATE Products
--SET ProductName = 'Updated Product'
--WHERE ProductID > 5;

--IF @@ROWCOUNT = 0
--    PRINT 'No rows were updated.';
--ELSE
--    PRINT CAST(@@ROWCOUNT AS VARCHAR) + ' rows were updated.';

--DELETE FROM Users
--WHERE UserName = 'NonExistentUser';

--IF @@ROWCOUNT = 0
--    PRINT 'No rows were deleted because the user does not exist.';
--ELSE
--    PRINT CAST(@@ROWCOUNT AS VARCHAR) + ' row(s) were deleted.';

--DECLARE @Counter INT = 1;

--WHILE @Counter <= 5
--BEGIN
--    INSERT INTO Products2 (ProductName)
--    VALUES ('Product ' + CAST(@Counter AS VARCHAR));

--    PRINT CAST(@@ROWCOUNT AS VARCHAR) + ' row(s) inserted in iteration ' + CAST(@Counter AS VARCHAR);

--    SET @Counter = @Counter + 1;
--END;
