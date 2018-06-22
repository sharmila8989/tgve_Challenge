CREATE TABLE [dbo].[Tour]
(
	[tourId] INT NOT NULL , 
    [tourName] NVARCHAR(20) NOT NULL, 
    [tourDescription] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_tour PRIMARY KEY (tourId)
	
)
