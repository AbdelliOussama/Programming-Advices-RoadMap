--DECLARE @OuterCounter INT =1;
--DECLARE @InnerCounter INT ;
--WHILE @OuterCounter <=5
--	BEGIN
--	SET @InnerCounter = 1;
--		WHILE @InnerCounter <=10
--			BEGIN 
--				PRINT 'Outer: '+Cast(@OuterCounter AS VARCHAR) +','+' Inner:'+CAST(@InnerCounter AS VARCHAR);
--				IF @OuterCounter + @InnerCounter = 12
--					BEGIN 
--						BREAK;
--					END
--				SET @InnerCounter  = @InnerCounter + 1;
--			END	
--	SET @OuterCounter =@OuterCounter +1;
--	END



----TasK 2

--DECLARE @Number INT =1;
--DECLARE  @Result INT;
--WHILE @Number <=12
--	BEGIN
--		SET @Result = 7 *@Number;
--		IF @Result  % 4 = 0
--			BEGIN  
--				SET @Number = @Number +1;
--				CONTINUE;
--			END
--		PRINT '7 x'+CAST(@Number AS VARCHAR)+' ='+CAST(@Result AS VARCHAR);
--		SET @Number = @Number +1;
--	END


--DECLARE @OuterCounter  INT= 1;
--DECLARE @InnerCounter INT ;
--DECLARE @Res INT ;
--DECLARE @RowString VARCHAR(255);
--WHILE @OuterCounter <=5
--	BEGIN 
--		SET @InnerCounter = 1;
--		SET @RowString = CHAR(9);
--		WHILE @InnerCounter <=10
--			BEGIN 
--				SET @Res = @InnerCounter * @OuterCounter;
--				SET @RowString = @RowString +CAST(@OuterCounter AS varchar)+'*'+CAST(@InnerCounter AS VARCHAR)+' = '+CAST(@Res AS VARCHAR)+CHAR(9);
--				SET @InnerCounter = @InnerCounter + 1;
--			END
--		PRINT @RowString ;
--		SET @OuterCounter = @OuterCounter +1;
--	END


	-- 10 x 10 Matrix Multiplication Table

DECLARE @row INT = 1;
DECLARE @col INT;
DECLARE @result INT;
DECLARE @rowString VARCHAR(255);
DECLARE @headerString VARCHAR(255);

-- Create the header row for the columns
SET @headerString = CHAR(9); -- Starting with a tab for the row header space
SET @col = 1;
WHILE @col <= 10
BEGIN
    SET @headerString = @headerString + CAST(@col AS VARCHAR) + CHAR(9); -- Append column headers
    SET @col = @col + 1;
END
PRINT @headerString;

-- Generate the multiplication table
WHILE @row <= 10
BEGIN
    SET @col = 1;
    SET @rowString = CAST(@row AS VARCHAR) + CHAR(9); -- Start each row with the row number

    WHILE @col <= 10
    BEGIN
        SET @result = @row * @col;
        SET @rowString = @rowString + CAST(@result AS VARCHAR) + CHAR(9); -- Append multiplication results
        SET @col = @col + 1;
    END

    PRINT @rowString; -- Print the row
    SET @row = @row + 1;
END

