BULK INSERT
	[dbo].[Table]
FROM 'C:\Users\pc\Desktop\Visual Studio\ASP.NET\laboratorio3\txts\ciudades.txt'
WITH(
	FIELDTERMINATOR=' ',
	ROWTERMINATOR='\n'
)

SELECT ciudad FROM dbo.[Table]