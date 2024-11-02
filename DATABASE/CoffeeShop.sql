

CREATE DATABASE Coffee_Shopp

--------------------------------CREARE TABELE---------------------------------------------
if OBJECT_ID('Client', 'u') is not null
	drop table Client
go
CREATE TABLE Client
(
IDClient int IDENTITY(1,1) PRIMARY KEY not null,
Nume nvarchar(20) not null,
Prenume nvarchar(20) not null,
DataNastere date,
Username nvarchar(20),
Email nvarchar(30),
Parola varchar(517)
)

if OBJECT_ID('Angajat', 'u') is not null
	drop table Angajat
go
CREATE TABLE Angajat
(
IDAngajat int IDENTITY(1,1) PRIMARY KEY not null,
Nume nvarchar(20) not null,
Prenume nvarchar(20) not null,
DataNastere date,
Username nvarchar(20),
Email nvarchar(30),
Parola varchar(517),
Rol nvarchar(8)
)
alter table Angajat
add NrTelefon nvarchar(10)

if OBJECT_ID('Produse', 'u') is not null
	drop table Produse
go
CREATE TABLE Produse
(
IDProdus int IDENTITY(1,1) PRIMARY KEY not null,
Denumire nvarchar(20),
Stoc int,
Pret decimal(10,2)
)

if OBJECT_ID('Cafele', 'u') is not null
	drop table Cafele
go
CREATE TABLE Cafele
(
IDProdus int IDENTITY(1,1) PRIMARY KEY not null,
Denumire nvarchar(10),
ShoturiEspresso int,
TipLapte nvarchar(10),
Sirop nvarchar(10),
Frisca int,
Pret int
)
ALTER TABLE Cafele
ALTER COLUMN TipLapte NVARCHAR(50);
ALTER TABLE Cafele
ALTER COLUMN Sirop NVARCHAR(50);

if OBJECT_ID('Mese', 'u') is not null
	drop table Mese
go
CREATE TABLE Mese
(
IDMasa int IDENTITY(1,1) PRIMARY KEY not null,
DataRezervare date,
NumarLocuriDisponibile int
)
ALTER TABLE Mese
ADD OraRezervare NVARCHAR(6);

if OBJECT_ID('Comenzi', 'u') is not null
	drop table Comenzi
go
CREATE TABLE Comenzi
(
IDComanda int IDENTITY(1,1) PRIMARY KEY not null,
IDClient int foreign key references Client(IDClient),
IDAngajat int foreign key references Angajat(IDAngajat), -- e null la inceput
DataComanda date,
ModalitatePlata int,
Pret decimal(10,2)
)

if OBJECT_ID('DetaliiComenzi', 'u') is not null
	drop table DetaliiComenzi
go
CREATE TABLE DetaliiComenzi
(
IDDetaliiComanda int IDENTITY(1,1) PRIMARY KEY not null,
IDComanda int foreign key references Comenzi(IDComanda),
IDCafea int foreign key references Cafele(IDProdus),
IDMasa int foreign key references Mese(IDMasa), --se duce
Cantitate int, -- se duce
NrPersoane int -- se deuce
)

if OBJECT_ID('Rezervari', 'u') is not null
	drop table Rezervari
go
CREATE TABLE Rezervari
(
IDRezervare int IDENTITY(1,1) PRIMARY KEY not null,
IDClient int foreign key references Client(IDClient),
IDAngajat int foreign key references Angajat(IDAngajat), -- null la inceput
IDMasa int foreign key references Mese(IDMasa),
DataRezervare date,
NrLocuri int
)
ALTER TABLE Rezervari
ADD Ora NVARCHAR(6);


--------------------------------INSERARI---------------------------------------------

select * from Client

select * from Rezervari


INSERT INTO Client (Nume, Prenume, DataNastere, Username, Email, Parola) VALUES
('Popescu', 'Ion', '1990-01-01', 'ion.popescu', 'ion.popescu@example.com', 'parola123'),
('Ionescu', 'Maria', '1985-02-15', 'maria.ionescu', 'maria.ionescu@example.com', 'parola456'),
('Georgescu', 'Andrei', '1992-03-20', 'andrei.georgescu', 'andrei.georgescu@example.com', 'parola789'),
('Dumitrescu', 'Ana', '1988-04-10', 'ana.dumitrescu', 'ana.dumitrescu@example.com', 'parola101'),
('Marin', 'Alina', '1995-05-25', 'alina.marin', 'alina.marin@example.com', 'parola202'),
('Vasilescu', 'Cristian', '1987-06-30', 'cristian.vasilescu', 'cristian.vasilescu@example.com', 'parola303'),
('Radu', 'Elena', '1991-07-15', 'elena.radu', 'elena.radu@example.com', 'parola404');

INSERT INTO Angajat (Nume, Prenume, DataNastere, Username, Email, Parola, Rol, NrTelefon) VALUES
('Popa', 'Laura', '1985-01-05', 'laura.popa', 'laura.popa@example.com', 'parola123', 'manager', '0123456789'),
('Sava', 'Mihai', '1990-02-10', 'mihai.sava', 'mihai.sava@example.com', 'parola456', 'barista', '0987654321'),
('Neagu', 'Ioana', '1993-03-15', 'ioana.neagu', 'ioana.neagu@example.com', 'parola789', 'ospatar', '0345678901'),
('Cristea', 'Daniel', '1988-04-20', 'daniel.cristea', 'daniel.cristea@example.com', 'parola101', 'manager', '0678901234'),
('Munteanu', 'Roxana', '1987-05-25', 'roxana.munteanu', 'roxana.munteanu@example.com', 'parola202', 'barista', '0456789012'),
('Badea', 'Gabriel', '1992-06-30', 'gabriel.badea', 'gabriel.badea@example.com', 'parola303', 'ospatar', '0123456789'),
('Dobre', 'Simona', '1991-07-15', 'simona.dobre', 'simona.dobre@example.com', 'parola404', 'manager', '0987654321');


select * from Angajat

INSERT INTO Produse (Denumire, Stoc, Pret) VALUES
('shot espresso', 200, 7.00),
('lapte de vaca', 50, 2.00),
('lapte de ovaz', 50, 3.00),
('lapte de soia', 50, 3.00),
('lapte de orez', 50, 4.00),
('lapte de cocos', 50, 4.00),
('sirop de ciocolata', 50, 1.00),
('sirop de vanilie', 50, 1.00),
('sirop de caramel', 50, 1.00),
('sirop irish', 50, 1.00),
('sirop amaretto', 50, 1.00),
('sirop de cocos', 50, 1.00),
('frisca', 100, 1.00);


select * from Cafele
INSERT INTO Cafele (Denumire, ShoturiEspresso, TipLapte, Sirop, Frisca, Pret) VALUES
('Cappuccino', 2, 'Lapte integral', 'Vanilie', 1, 15),
('Latte', 1, 'Lapte semi-degresat', 'Caramel', 0, 12),
('Americano', 2, 'N/A', 'N/A', 0, 10),
('Mocha', 2, 'Lapte integral', 'Ciocolata', 1, 14),
('Espresso', 1, 'N/A', 'N/A', 0, 8),
('Macchiato', 1, 'Lapte integral', 'N/A', 0, 13),
('Flat White', 2, 'Lapte degresat', 'N/A', 0, 16);

INSERT INTO Comenzi (IDClient, IDAngajat, DataComanda, ModalitatePlata, Pret) VALUES
(1, NULL, '2024-10-30', 1, 25.00),
(2, 1, '2024-10-30', 2, 35.50),
(3, NULL, '2024-10-30', 1, 20.00),
(4, 2, '2024-10-30', 3, 15.00),
(5, NULL, '2024-10-30', 2, 30.00),
(6, 3, '2024-10-30', 1, 45.00),
(7, NULL, '2024-10-30', 3, 50.00);



INSERT INTO DetaliiComenzi (IDComanda, IDCafea, IDMasa, Cantitate, NrPersoane) VALUES
(1, 1, 1, 2, 4),
(2, 2, 2, 1, 2),
(3, 3, 3, 3, 3),
(4, 4, 4, 2, 2),
(5, 5, 5, 1, 1),
(6, 6, 6, 4, 4),
(7, 7, 7, 2, 2);



select * from Mese
INSERT INTO Mese (DataRezervare, NumarLocuriDisponibile, OraRezervare) VALUES
('2024-10-30', 4, '18:00'),
('2024-10-30', 2, '19:00'),
('2024-10-30', 6, '20:00'),
('2024-10-30', 8, '21:00'),
('2024-10-30', 4, '18:30'),
('2024-10-30', 2, '19:30'),
('2024-10-30', 6, '20:30');


INSERT INTO Mese (DataRezervare, NumarLocuriDisponibile) VALUES
(NULL, 2),
(NULL, 2),
(NULL, 2),
(NULL, 2),
(NULL, 3),
(NULL, 3),
(NULL, 3),
(NULL, 3),
(NULL, 3),
(NULL, 4),
(NULL, 4),
(NULL, 4),
(NULL, 5),
(NULL, 5);

INSERT INTO Rezervari (IDClient, IDAngajat, IDMasa, DataRezervare, NrLocuri, Ora) VALUES
(1, NULL, 1, '2024-10-30', 4, '18:00'),
(2, 1, 2, '2024-10-30', 2, '19:00'),
(3, NULL, 3, '2024-10-30', 6, '20:00'),
(4, 2, 4, '2024-10-30', 8, '21:00'),
(5, NULL, 5, '2024-10-30', 4, '18:30'),
(6, 3, 6, '2024-10-30', 2, '19:30'),
(7, NULL, 7, '2024-10-30', 6, '20:30');

CREATE PROCEDURE GetNrLocuriByIdRezervare
    @IDRezervare INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT NrLocuri
    FROM Rezervari
    WHERE IDRezervare = @IDRezervare;
END;





delete from Rezervari

INSERT INTO Rezervari (IDClient, IDAngajat, IDMasa, DataRezervare, NrLocuri, Ora) VALUES
(8, NULL, 2, '2024-11-02', 2, '17:00'),
(1, NULL, 2, '2024-11-02', 2, '18:00'),
(1, NULL, 3, '2024-11-02', 2, '19:00'),
(1, NULL, 1, '2024-11-02', 2, '20:00'),
(1, NULL, 2, '2024-11-02', 2, '20:30'),
(1, NULL, 3, '2024-11-02', 3, '21:00'),
(1, NULL, 4, '2024-11-02', 2, '21:30');


select * from Client

INSERT INTO Comenzi (IDClient, IDAngajat, DataComanda, ModalitatePlata, Pret) VALUES
(1, 1, '2024-10-31', 1, 27.50),
(2, NULL, '2024-10-31', 2, 22.00)


INSERT INTO Comenzi (IDClient, IDAngajat, DataComanda, ModalitatePlata, Pret) VALUES
(1, , '2024-11-2', 1, 27.50),
(2, NULL, '2024-11-2', 2, 22.00)

delete from Comenzi


INSERT INTO Comenzi (IDClient, IDAngajat, DataComanda, ModalitatePlata, Pret) VALUES
(1, NULL, '2024-11-2', 1, 27.50),
(2, NULL, '2024-11-2', 2, 22.00)

select * from Comenzi where Comenzi.DataComanda = '2024-11-2'



INSERT INTO Comenzi (IDClient, IDAngajat, DataComanda, ModalitatePlata, Pret) VALUES
(1, 1, '2024-10-30', 1, 27.50),
(2, NULL, '2024-10-30', 2, 22.00),
(3, 2, '2024-10-30', 1, 30.00),
(4, NULL, '2024-10-30', 3, 18.00),
(5, 3, '2024-10-30', 1, 45.00),
(6, NULL, '2024-10-30', 2, 32.50),
(7, 1, '2024-10-30', 1, 15.00),
(7, 2, '2024-10-30', 2, 40.00),
(7, NULL, '2024-10-30', 3, 29.99),
(5, 3, '2024-10-30', 1, 36.75);

UPDATE Comenzi
SET IDAngajat = NULL;


select * from Comenzi




CREATE PROCEDURE UpdateIDAngajatByIdComanda
    @IDAngajat INT,
    @IDComanda INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Comenzi
    SET IDAngajat = @IDAngajat
    WHERE IDComanda = @IDComanda;
END



CREATE PROCEDURE GetClientNameByOrderId
    @IDComanda INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.Nume, 
        c.Prenume
    FROM 
        Comenzi co
    JOIN 
        Client c ON co.IDClient = c.IDClient
    WHERE 
        co.IDComanda = @IDComanda;
END


CREATE PROCEDURE GetClientNameByReservationId
    @IDRezervare INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.Nume, 
        c.Prenume
    FROM 
        Rezervari ro
    JOIN 
        Client c ON ro.IDClient = c.IDClient
    WHERE 
        ro.IDRezervare = @IDRezervare;
END




CREATE PROCEDURE GetEmployeeIdByEmail
    @Email NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IDAngajat
    FROM 
        Angajat
    WHERE 
        Email = @Email;
END




select * from Comenzi




CREATE PROCEDURE UpdateIDAngajatByIdRezervare
    @IDAngajat INT,
    @IDRezervare INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Rezervari
    SET IDAngajat = @IDAngajat
    WHERE IDRezervare = @IDRezervare;
END


CREATE PROCEDURE GetRolByEmail
    @Email NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Rol
    FROM Angajat
    WHERE Email = @Email;
END;




CREATE PROCEDURE GetNumeByEmail
    @Email NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Nume
    FROM Angajat
    WHERE Email = @Email;
END;


CREATE PROCEDURE GetPrenumeByEmail
    @Email NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Prenume
    FROM Angajat
    WHERE Email = @Email;
END;






CREATE PROCEDURE GetNumePrenumeByEmail
    @Email NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Nume, Prenume
    FROM Angajat
    WHERE Email = @Email;
END;



INSERT INTO Angajat (Nume, Prenume, DataNastere, Username, Email, Parola, Rol, NrTelefon) VALUES
('Ionescu', 'Adriana', '1990-08-10', 'adriana.ionescu', 'adriana.ionescu@example.com', 
 RIGHT(CONVERT(VARCHAR(128), HASHBYTES('SHA2_512', 'parola555'), 2), 128), 'manager', '0234567890'),

('Radulescu', 'Andrei', '1985-09-12', 'andrei.radulescu', 'andrei.radulescu@example.com', 
 RIGHT(CONVERT(VARCHAR(128), HASHBYTES('SHA2_512', 'parola666'), 2), 128), 'barista', '0789012345'),

('Popescu', 'Cristina', '1994-10-05', 'cristina.popescu', 'cristina.popescu@example.com', 
 RIGHT(CONVERT(VARCHAR(128), HASHBYTES('SHA2_512', 'parola777'), 2), 128), 'ospatar', '0345618902'),

('Lazar', 'Marius', '1986-11-22', 'marius.lazar', 'marius.lazar@example.com', 
 RIGHT(CONVERT(VARCHAR(128), HASHBYTES('SHA2_512', 'parola888'), 2), 128), 'manager', '0567890123'),

('Petrescu', 'Bianca', '1995-12-08', 'bianca.petrescu', 'bianca.petrescu@example.com', 
 RIGHT(CONVERT(VARCHAR(128), HASHBYTES('SHA2_512', 'parola999'), 2), 128), 'barista', '0654789012'),

('Georgescu', 'Alexandru', '1989-01-17', 'alexandru.georgescu', 'alexandu.georgescu@example.com', 
 RIGHT(CONVERT(VARCHAR(128), HASHBYTES('SHA2_512', 'parola111'), 2), 128), 'ospatar', '0981234567'),

('Nistor', 'Ioan', '1992-02-14', 'ioan.nistor', 'ioan.nistor@example.com', 
 RIGHT(CONVERT(VARCHAR(128), HASHBYTES('SHA2_512', 'parola222'), 2), 128), 'manager', '0123987654');



 select *  from Angajat

