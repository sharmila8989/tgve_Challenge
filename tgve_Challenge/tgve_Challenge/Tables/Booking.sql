CREATE TABLE [dbo].[Booking]
(
	[bookingDate] DATE NOT NULL,
    [bookingPayment] DECIMAL(18, 2) NOT NULL, 
    [clientId] INT NOT NULL, 
    [tourId] INT NOT NULL, 
    [eventMonth] NVARCHAR(10) NOT NULL, 
    [eventDay] INT NOT NULL, 
    [eventYear] INT NOT NULL,
	CONSTRAINT PK_booking PRIMARY KEY (clientId, tourId, eventMonth, eventDay, eventYear),
	CONSTRAINT FK_bookingClientId FOREIGN KEY (clientId) REFERENCES Client(clientId),
	CONSTRAINT FK_booking FOREIGN KEY (tourId, eventMonth, eventDay, eventYear) REFERENCES TourEvent(tourId, eventMonth, eventDay, eventYear)

)
