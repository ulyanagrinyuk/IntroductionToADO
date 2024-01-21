CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[last_name]		NVARCHAR(100) NOT NULL,
	[first_name]	NVARCHAR(100) NOT NULL,
	[birth_day]		DATE	NOT NULL,
	[Passage to the red light]CHAR(10) NOT NULL,
	[Speeding]CHAR(10) NOT NULL,
	[Parking in the wrong place]CHAR(10) NOT NULL,
	[Drunk driving]CHAR(10) NOT NULL,
	[Insulting an officer]CHAR(10) NOT NULL,
	[Seat belt]CHAR(100) NOT NULL,


)
GO
