CREATE DATABASE CoffeeShop
ON PRIMARY
(
    Name = CoffeeShop_a,
    FileName = 'D:\ATM\Anul 3\Sem 1\Ap Baze de date\Proiect\CoffeeShop.mdf',
    Size = 15MB, -- KB, Mb, GB, TB
    MaxSize = UNLIMITED,
    FileGrowth = 15MB
),
(
    Name = CoffeeShop_b,
    FileName = 'D:\ATM\Anul 3\Sem 1\Ap Baze de date\Proiect\CoffeeShop.ndf',
    Size = 15MB, -- KB, Mb, GB, TB
    MaxSize = UNLIMITED,
    FileGrowth = 15MB
),
(
    Name = CoffeeShop_c,
    FileName = 'D:\ATM\Anul 3\Sem 1\Ap Baze de date\Proiect\CoffeeShop1.ndf',
    Size = 15MB, -- KB, Mb, GB, TB
    MaxSize = UNLIMITED,
    FileGrowth = 15MB
)
LOG ON
(
    Name = CoffeeShopa_log,
    FileName = 'D:\ATM\Anul 3\Sem 1\Ap Baze de date\Proiect\CoffeeShop.ldf',
    Size = 10MB, -- KB, Mb, GB, TB
    MaxSize = UNLIMITED,
    FileGrowth = 15MB
),
(
    Name = CoffeeShopb_log,
    FileName = 'D:\ATM\Anul 3\Sem 1\Ap Baze de date\Proiect\CoffeeShop1.ldf',
    Size = 10MB, -- KB, Mb, GB, TB
    MaxSize = UNLIMITED,
    FileGrowth = 15MB
);


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
Email nvarchar(30)
)
Alter table Client
ADD Parola VARCHAR(517)


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
Rol nvarchar(8)
)
Alter table Angajat
ADD Parola VARCHAR(517)


if OBJECT_ID('Produse', 'u') is not null
	drop table Produse
go
CREATE TABLE Produse
(
IDProdus int IDENTITY(1,1) PRIMARY KEY not null,
Denumire nvarchar(10),
Stoc int,
Pret decimal(10,2)
)


if OBJECT_ID('Vouchere', 'u') is not null
	drop table Vouchere
go
CREATE TABLE Vouchere
(
IDVoucher int IDENTITY(1,1) PRIMARY KEY not null,
IDClient int foreign key references Client(IDClient),
Valoare decimal(10,2)
)


if OBJECT_ID('Comenzi', 'u') is not null
	drop table Comenzi
go
CREATE TABLE Comenzi
(
IDComanda int IDENTITY(1,1) PRIMARY KEY not null,
IDClient int foreign key references Client(IDClient),
IDAngajat int foreign key references Angajat(IDAngajat),
DataComanda date,
ModalitatePlata int,
Pret decimal(10,2)
)

if OBJECT_ID('Mese', 'u') is not null
	drop table Mese
go
CREATE TABLE Mese
(
IDMasa int IDENTITY(1,1) PRIMARY KEY not null,
DataRezervare date,
NumarLocuriDisponibile int
)


if OBJECT_ID('DetaliiComenzi', 'u') is not null
	drop table DetaliiComenzi
go
CREATE TABLE DetaliiComenzi
(
IDDetaliiComanda int IDENTITY(1,1) PRIMARY KEY not null,
IDComanda int foreign key references Comenzi(IDComanda),
IDProdus int foreign key references Produse(IDProdus),
IDMasa int foreign key references Mese(IDMasa),
Cantitate int,
NrPersoane int
)


if OBJECT_ID('Rezervari', 'u') is not null
	drop table Rezervari
go
CREATE TABLE Rezervari
(
IDRezervare int IDENTITY(1,1) PRIMARY KEY not null,
IDClient int foreign key references Client(IDClient),
IDAngajat int foreign key references Angajat(IDAngajat),
DataRezervare date,
NrLocuri int,
NrMasa int
)


insert into Angajat(Nume, Prenume, DataNastere, Username, Email, Rol, Parola) values
('Popescu', 'Cristian', '19931103', 'cristi.popescu', 'popescu.cristian@gmail.com', 'admin', RIGHT(CONVERT(VARCHAR(128), HASHBYTES('SHA2_512', 'KLMNOP1'), 2), 128));

select * from Angajat

delete from Angajat

