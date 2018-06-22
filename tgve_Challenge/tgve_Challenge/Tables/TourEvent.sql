CREATE TABLE [dbo].[TourEvent]
(
	[eventMonth] NVARCHAR(10) NOT NULL,
    [eventDay] INT NOT NULL, 
    [eventYear] INT NOT NULL, 
    [eventFee] DECIMAL(18, 2) NOT NULL, 
    [tourId] INT NOT NULL,
	CONSTRAINT PK_tourEvent PRIMARY KEY(tourId, eventMonth, eventDay, eventYear),
	CONSTRAINT FK_tourId FOREIGN KEY (tourId) REFERENCES Tour(tourId)
)
