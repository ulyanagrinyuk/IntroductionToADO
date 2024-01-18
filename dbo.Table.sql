CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[last_name]		NVARCHAR(100) NOT NULL,
	[first_name]	NVARCHAR(100) NOT NULL,
	[birth_day]		DATE	NOT NULL,
)
GO