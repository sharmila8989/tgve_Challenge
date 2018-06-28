tour/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF '$(LoadTestData)' = 'true'

BEGIN 

DELETE FROM Booking;
DELETE FROM TourEvent;
DELETE FROM Client;
DELETE FROM Tour;

INSERT INTO Tour ( tourId, tourName, tourDescription) 
VALUES 
(1, 'West', 'Tour of wineries and outlets of the Geelong and Otways region'),
(2, 'East', 'Tour of wineries and outlets of the Yarra Valley'),
(3, 'South', 'Tour of wineries and outlets of Mornington Penisula'),
(4, 'North', 'Tour of wineries and outlets of the Bedigo and Castlemaine region');


INSERT INTO Client(clientId, clientSurname, clientGivenName, clientGender)
VALUES 
(1, 'Price', 'Taylor', 'M'),
(2, 'Gamble', 'Ellyse', 'F'),
(3, 'Tan', 'Tilly', 'F');


INSERT INTO TourEvent (tourId, eventMonth, eventDay, eventYear, eventFee)
values
(4,'Jan', 9, 2016, 200),
(4,'Feb', 13, 2016, 225),
(3,'Jan', 16, 2016, 200),
(1,'Jan', 29, 2016, 225);


INSERT INTO Booking (clientId, tourId, eventMonth, eventDay, eventYear, bookingPayment,bookingDate)
VALUES
(1,	4, 'Jan', 9, 2016, 200,	'2015/12/10'),
(2,	4,	'Feb', 13,	2016, 225, '2016/01/14'),
(3,	4,	'Feb',	13,	2016,	225, '2016/2/3'),
(1,	3,	'Jan',	16,	2016,	200, '2015/12/10'),
(2,	3,	'Jan',	16,	2016,	200, '2015/12/18'),
(3,	3,	'Jan',	16,	2016,	200, '2016/01/9'),
(2,	1,	'Jan',	29,	2016,	200, '2015/12/17'),
(3,	1,	'Jan',	29,	2016,	200, '2015/12/18');

END;
