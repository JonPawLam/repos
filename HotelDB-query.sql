 --Creating Database
 --CREATE DATABASE HotelDB

--Oprettelse af Hotel Tabel
CREATE TABLE Hotel (
HotelNo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
HotelName NVARCHAR(30) NOT NULL,
HotelAddress NVARCHAR(50) NOT NULL
)


--Oprettelse af Room Tabel
CREATE TABLE Room (
RoomNo INT NOT NULL,
HotelNo INT NOT NULL,
RoomType CHAR(1) DEFAULT 'S',
Price FLOAT,

--Regler for roomtype og price
CONSTRAINT CheckRoomType
CHECK (RoomType IN ('D','F','S') OR RoomType IS NULL),

CONSTRAINT CheckPrice
CHECK (Price BETWEEN 0 AND 9999),

--Tildeling af Foreign og Primary Keys samt update. 
FOREIGN KEY (HotelNo) REFERENCES dbo.Hotel (HotelNo)
ON UPDATE CASCADE 
ON DELETE NO ACTION,
PRIMARY KEY (RoomNo, HotelNo)
)


--Creating Guests Table
CREATE TABLE Guests (
GuestNo INT PRIMARY KEY NOT NULL,
GuestName NVARCHAR(30) NOT NULL,
GuestAddress NVARCHAR(50) NOT NULL
)

--Creating Booking Table
CREATE TABLE Booking (
BookingID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
HotelNo INT NOT NULL,
GuestNo INT NOT NULL,
DateFrom DATE NOT NULL,
DateTo DATE NOT NULL,
RoomNo INT NOT NULL,

FOREIGN KEY (GuestNo) REFERENCES dbo.Guests(GuestNo),
FOREIGN KEY (RoomNo,HotelNo) REFERENCES dbo.Room(RoomNo, HotelNo)
)

--Tilføjelse af Check Af Korrekte Datoer
ALTER TABLE dbo.Booking 
ADD CONSTRAINT IncorrectDates
CHECK ((DateTo > DateFrom) AND (DateFrom >= '2009-01-01'))


-- Query Opgaver

-- Select opgaver
--1 Info om alle hoteller
SELECT * FROM dbo.Hotel

--2 info omkring hoteller i roskilde
SELECT * FROM dbo.Hotel
WHERE HotelAddress LIKE '%roskilde%'

--3 navn og addresse fra guests fra roskilde
SELECT GuestName, GuestAddress FROM dbo.Guests
WHERE GuestAddress LIKE '%roskilde%'

--4 sorterede navn og addresse fra Guests fra roskilde
SELECT GuestName, GuestAddress FROM dbo.Guests
WHERE GuestAddress LIKE '%roskilde%'
ORDER BY GuestName ASC

--5 Double værelse med pris under 200
SELECT * FROM dbo.Room
WHERE Price < 200 AND RoomType = 'D'

--6 liste af alle Double værelser og familie værelser med en pris under 400
SELECT * FROM dbo.Room
WHERE Price < 400 AND RoomType = 'D' OR RoomType = 'F'

--7 liste af alle double og familie værelser m. pris på under 400 i rækkefølge
SELECT * FROM dbo.Room
WHERE Price < 400 AND RoomType = 'D' OR RoomType = 'F'
ORDER BY Price ASC

--8 liste af alle Guests der starter med G
SELECT * FROM dbo.Guests
WHERE GuestName LIKE 'G%'

-- Aggregate opgaver
--9 hvor mange hoteller der er
SELECT COUNT(*) FROM dbo.Hotel

--10 hvor mange hoteller i roskilde
SELECT COUNT(*) FROM dbo.Hotel
WHERE HotelAddress LIKE '%roskilde%'

--11  hvad er gennemsnitsprisen for et værelse?
SELECT ROUND(AVG(Price),2) FROM dbo.Room

--12 gennemsnitspris for et single værelse
SELECT ROUND(AVG(Price),0) FROM dbo.Room
WHERE RoomType = 'S'

--13 gennemsnitspris af et double værelse
SELECT ROUND(AVG(Price),0) FROM dbo.Room
WHERE RoomType = 'D'

--14 gennemsnitspris af et værelse hos hotel scandic
SELECT ROUND(AVG(Price),2) FROM dbo.Room,dbo.Hotel
WHERE HotelName LIKE '%scandic%'

--15 total omsætning pr. night for all double
SELECT ROUND(SUM(Price),2) FROM dbo.Room
WHERE RoomType = 'D'

--16 hvor mange gæster har booket i marts
SELECT COUNT(GuestNo) FROM dbo.Booking
WHERE  DateFrom BETWEEN '2019-03-01' AND '2019-03-31'

--17 hvor mange bookinger der er idag på scandic hotel
SELECT * FROM dbo.Booking,dbo.Hotel
WHERE HotelName LIKE '%scandic%' AND (DateFrom <= CONVERT(DATE,GETDATE()) AND DateTo >= CONVERT(DATE,GETDATE()))

--18 hvor mange bookinger der er idag om morgenen på scandic hotel... ingen tidsangivelser i vores data??? how do dis?
SELECT * FROM dbo.Booking,dbo.Hotel
WHERE HotelName LIKE '%scandic%' AND (DateFrom <= CONVERT(DATE,GETDATE()) AND DateTo >= CONVERT(DATE,GETDATE()))

--19 liste af pris og type af rum på hotel Prince
SELECT Price, RoomType FROM dbo.Room,dbo.Hotel
WHERE HotelName LIKE '%prindsen%'

--20 liste af alle gæster der P.T er på prindsen
SELECT GuestName FROM dbo.Guests,dbo.Hotel,dbo.Booking
WHERE HotelName LIKE '%%prindsen' AND Booking.GuestNo = Guests.GuestNo AND (DateFrom <= CONVERT(DATE,GETDATE()) AND DateTo >= CONVERT(DATE,GETDATE()))


--21 liste af all information om alle rum fra hotel Prindsen inkl navnet på gæster i rum. 
SELECT room.RoomNo, room.HotelNo, room.RoomType, room.RoomType, GuestName FROM dbo.Room
LEFT JOIN dbo.Booking ON booking.RoomNo = room.RoomNo AND booking.HotelNo = Room.HotelNo
LEFT JOIN dbo.Guests ON Guests.GuestNo = Booking.GuestNo
WHERE room.HotelNo = 6

--22. What is the total income for all bookings on 'Prince' today?

SELECT sum (room.Price) 
FROM 
dbo.Guests LEFT JOIN dbo.Booking ON room.RoomNo = booking. 




--LIKE '%%prindsen' AND Booking.GuestNo = Guests.GuestNo AND (DateFrom <= CONVERT(DATE,GETDATE()) AND DateTo >= CONVERT(DATE,GETDATE()))



--AND Booking.GuestNo = Guests.GuestNo AND (DateFrom <= CONVERT(DATE,GETDATE()) AND DateTo >= CONVERT(DATE,GETDATE()))
