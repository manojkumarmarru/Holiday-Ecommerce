CREATE TABLE Destinations (
    destinationId VARCHAR(10) PRIMARY KEY,
    continent VARCHAR(50),
    imageUrl VARCHAR(255),
    name VARCHAR(255),
    description TEXT,
    noOfNights DECIMAL(4, 1),
    flightCharges DECIMAL(10, 2),
    chargesPerPerson DECIMAL(10, 2),
    discount DECIMAL(4, 1),
    availability INT
);

