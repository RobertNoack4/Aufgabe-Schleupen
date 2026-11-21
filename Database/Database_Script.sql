-- Datenbank erstellen
CREATE DATABASE PersonenVerwaltung;
GO

USE PersonenVerwaltung
GO

-- Personen Tabelle erzeugen
CREATE TABLE Personen (
	PersonID int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(255),
	Vorname varchar(255),
	Geburtsdatum date 
);

--Anschrifts Tabelle erzeugen
CREATE TABLE Anschrift(
	AnschriftID int IDENTITY(1,1) PRIMARY KEY,
	Postleitzahl varchar(15),
	Ort varchar (255),
	Straße varchar (255),
	Hausnummer varchar (15),
	PersonID int NOT NULL,

	CONSTRAINT fk_anschrift_personen
		FOREIGN KEY (PersonID)
		REFERENCES Personen(PersonID)
		ON DELETE NO ACTION
);

--Telefonverbindungs Tabelle erzeugen
CREATE TABLE Telefonverbindung(
	TelefonverbindungsID int IDENTITY(1,1) PRIMARY KEY,
	Nummer varchar(20),
	PersonID int NOT NULL,

	CONSTRAINT fk_telfonverbindung_personen
		FOREIGN KEY (PersonID)
		REFERENCES Personen(PersonID)
		ON DELETE NO ACTION
);

-- Seeding of Database
BEGIN TRANSACTION;

INSERT INTO	Personen
VALUES ('Bauer', 'Fritz', '1990-04-23')

DECLARE @personenID int = SCOPE_IDENTITY()

INSERT INTO Anschrift
VALUES ('74078', 'Heilbronn', 'Kurfuerstendamm', '90', @personenID)

INSERT INTO Anschrift
VALUES ('74071', 'Heilbronn', 'Mauer Straße', '120', @personenID)

INSERT INTO Telefonverbindung
VALUES ('+4917646991663', @personenID)

INSERT INTO Telefonverbindung
VALUES ('+4915542267102', @personenID)

COMMIT TRANSACTION

GO

BEGIN TRANSACTION;

INSERT INTO	Personen
VALUES ('Maier', 'Lars', '1992-04-23')

DECLARE @personenID int = SCOPE_IDENTITY()

INSERT INTO Anschrift
VALUES ('01123', 'Dresden', 'Bauernweg', '12b', @personenID)

INSERT INTO Anschrift
VALUES ('01345', 'Leipzig', 'Mauer Straße', '20', @personenID)

INSERT INTO Telefonverbindung
VALUES ('04917646991433', @personenID)

INSERT INTO Telefonverbindung
VALUES ('4915322267102', @personenID)

COMMIT TRANSACTION

GO

BEGIN TRANSACTION;

INSERT INTO	Personen
VALUES ('Walter', 'Marie', '1989-06-21')

DECLARE @personenID int = SCOPE_IDENTITY()

INSERT INTO Anschrift
VALUES ('02567', 'Berlin', 'Land Straße', '4', @personenID)

INSERT INTO Anschrift
VALUES ('02567', 'Berlin', 'Land Straße', '6', @personenID)

INSERT INTO Telefonverbindung
VALUES ('+4917376991663', @personenID)

COMMIT TRANSACTION

--Wie viele Personendatensätze sind vorhanden
SELECT COUNT(*) AS Anzahl_Datensätze FROM Personen

--Wie viele Personen wohnen in Dresden
SELECT COUNT(DISTINCT PersonID) AS Wohnen_In_Dresden FROM Anschrift
WHERE Ort = 'Dresden';

--Wie viele Personen haben mehr als eine Telefonnummer
SELECT COUNT(*) AS Mehr_als_eine_Telefonnummer FROM 
	(SELECT Count(PersonID) AS ergebnis FROM Telefonverbindung
	GROUP BY PersonID
	Having Count (PersonID) > 1) 
AS ergebnis;

--Anzahl an Personen pro Ort
SELECT Ort, Count(Ort) AS Anzahl_Personen From Anschrift
GROUP BY Ort
ORDER BY Anzahl_Personen DESC

-- View mit allen Personen und deren Anschriften und Telefonnummern
GO
Create View PersonenKomplett AS
SELECT Personen.Name, Personen.Vorname, Personen.Geburtsdatum, Anschrift.Postleitzahl, Anschrift.Ort, Anschrift.Straße, Anschrift.Hausnummer, Telefonverbindung.Nummer FROM Personen
INNER JOIN Anschrift
ON Personen.PersonID = Anschrift.PersonID
INNER JOIN Telefonverbindung
ON Personen.PersonID = Telefonverbindung.PersonID

GO
-- Entferne alle Telefonnummern die nicht mit 0 oder + beginnen
DELETE FROM Telefonverbindung
WHERE SUBSTRING(Nummer, 1, 1) != '0' AND SUBSTRING(Nummer, 1, 1) != '+';

-- Spalte hinzufügen für Uppercase Vor- und Nachname
ALTER TABLE Personen
ADD Name_Groß varchar(510)

-- Spalte für Uppercase Vor- und Nachname befüllen
UPDATE Personen
SET Name_Groß = Concat(UPPER(Vorname), ' ', UPPER(Name))