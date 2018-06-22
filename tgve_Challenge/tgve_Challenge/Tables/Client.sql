CREATE TABLE [dbo].[Client]
(
	[clientId] INT NOT NULL,
    [clientGivenName] NVARCHAR(30) NOT NULL, 
    [clientSurname] NVARCHAR(30) NOT NULL,
	[clientGender] NCHAR(1) NOT NULL, 
    CONSTRAINT PK_Client PRIMARY KEY (clientId)
)
