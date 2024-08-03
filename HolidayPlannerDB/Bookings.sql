IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bookings]') AND type in (N'U'))
BEGIN
    CREATE TABLE Bookings (
        bookingId VARCHAR(10) PRIMARY KEY,
        userId VARCHAR(10),
        destId VARCHAR(10),
        destinationName VARCHAR(255),
        checkInDate DATE,
        checkOutDate DATE,
        noOfPersons INT,
        totalCharges DECIMAL(10, 2),
        timeStamp DATETIME,
        FOREIGN KEY (userId) REFERENCES Users(userId)
    );
END
