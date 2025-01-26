DECLARE @Text NVARCHAR(50) = 'Hello, T-SQL World!';
SELECT LEN(@Text) AS TextLength;
SELECT CHARINDEX('T-SQL', @Text) AS PositionOfTSql;


DECLARE @Text NVARCHAR(50) = 'Learning SQL is Fun!';
SELECT UPPER(SUBSTRING(@Text, 10, 3)) AS ExtractedUpperCasePart;


DECLARE @Text NVARCHAR(50) = '  SQL Programming  ';
SELECT REPLACE(LTRIM(RTRIM(@Text)), 'SQL', 'T-SQL') AS CleanedAndReplaced;


