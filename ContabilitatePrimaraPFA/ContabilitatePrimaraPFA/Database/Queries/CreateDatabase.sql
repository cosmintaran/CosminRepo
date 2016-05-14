
CREATE TABLE Judet
(
JudetId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
[Denumire Judet] nvarchar(15) NOT NULL
)

INSERT INTO Judet VALUES ('Alba')
INSERT INTO Judet VALUES ('Arad')
INSERT INTO Judet VALUES ('Arges')
INSERT INTO Judet VALUES ('Bacau')
INSERT INTO Judet VALUES ('Bihor')
INSERT INTO Judet VALUES ('Bistrita-Nasaud')
INSERT INTO Judet VALUES ('Botosani')
INSERT INTO Judet VALUES ('Braila')
INSERT INTO Judet VALUES ('Brasov')
INSERT INTO Judet VALUES ('Bucuresti')
INSERT INTO Judet VALUES ('Buzau')
INSERT INTO Judet VALUES ('Calarasi')
INSERT INTO Judet VALUES ('Caras-Severin')
INSERT INTO Judet VALUES ('Cluj')
INSERT INTO Judet VALUES ('Constanta')
INSERT INTO Judet VALUES ('Covasna')
INSERT INTO Judet VALUES ('Dambovita')
INSERT INTO Judet VALUES ('Dolj')
INSERT INTO Judet VALUES ('Galati')
INSERT INTO Judet VALUES ('Giurgiu')
INSERT INTO Judet VALUES ('Gorj')
INSERT INTO Judet VALUES ('Harghita')
INSERT INTO Judet VALUES ('Hunedoara')
INSERT INTO Judet VALUES ('Ialomita')
INSERT INTO Judet VALUES ('Iasi')
INSERT INTO Judet VALUES ('Ilfov')
INSERT INTO Judet VALUES ('Maramures')
INSERT INTO Judet VALUES ('Mehedinti')
INSERT INTO Judet VALUES ('Mures')
INSERT INTO Judet VALUES ('Neamt')
INSERT INTO Judet VALUES ('Olt')
INSERT INTO Judet VALUES ('Prahova')
INSERT INTO Judet VALUES ('Salaj')
INSERT INTO Judet VALUES ('Satu-Mare')
INSERT INTO Judet VALUES ('Sibiu')
INSERT INTO Judet VALUES ('Suceava')
INSERT INTO Judet VALUES ('Teleorman')
INSERT INTO Judet VALUES ('Timis')
INSERT INTO Judet VALUES ('Valcea')
INSERT INTO Judet VALUES ('Vaslui')
INSERT INTO Judet VALUES ('Vrancea')

CREATE TABLE ReceptionatRespins
(
ReceptionatRespinsId INT NOT NULL Identity(1,1) PRIMARY KEY,
StatusRec NVARCHAR(11) NOT NULL 
)

INSERT INTO ReceptionatRespins VALUES('In Lucru')
INSERT INTO ReceptionatRespins VALUES('Receptionat')
INSERT INTO ReceptionatRespins VALUES('Respins')

CREATE TABLE AcceptataRefuzata
(
AcceptataRefuzataId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
StatusAccept nvarchar(10) NOT NULL
)
INSERT INTO AcceptataRefuzata VALUES('Acceptata')
INSERT INTO AcceptataRefuzata VALUES('Refuzata')

CREATE TABLE TipLucrare
(
TipLucrareId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
[CodLucrare] nvarchar(5) NOT NULL,
[TipLucrare] nvarchar(125) NOT NULL
)

INSERT INTO TipLucrare VALUES('1.1.1','Aviz incepere lucrari')
INSERT INTO TipLucrare VALUES('1.1.2','Receptie tehnica pentru lucrari de masuratori terestre')
INSERT INTO TipLucrare VALUES('2.1.1','Receptie si infiintare carte funciara')
INSERT INTO TipLucrare VALUES('2.1.2','Receptie (nr. cadastral)')
INSERT INTO TipLucrare VALUES('2.1.3','Infiintare carte funciara')
INSERT INTO TipLucrare VALUES('2.2.1','Receptie dezmembrare / comasare')
INSERT INTO TipLucrare VALUES('2.2.2','Inscriere dezmembrare / comasare in cartea funciara')
INSERT INTO TipLucrare VALUES('2.2.3','Dezmembrare pentru exproprieri')
INSERT INTO TipLucrare VALUES('2.5.1','Indreptare eroare materiala si repozitionare imobil')
INSERT INTO TipLucrare VALUES('2.5.2','Rectificare limite imobil si modificare suprafata')
INSERT INTO TipLucrare VALUES('2.5.3','Reconstituire carte funciara')
INSERT INTO TipLucrare VALUES('2.6.1','Inscriere constructii')
INSERT INTO TipLucrare VALUES('2.6.2','Extindere sau desfiintare constructii si actualizare categorie de folosinta, destinatie sau alte informatii tehnice')


CREATE TABLE TipAct
(
TipActId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
TipAct NVARCHAR(22) not null
)
INSERT INTO TipAct (TipAct) Values ('Buletin de Identitate');
INSERT INTO TipAct (TipAct) Values ('Carte de Identitate');
INSERT INTO TipAct (TipAct) Values ('Pasaport');

CREATE TABLE Beneficiar 
(BeneficiarId int NOT NULL Identity(1,1) Primary Key,
Nume NVARCHAR(40) NOT NULL,
Prenume NVARCHAR(50) NOT NULL,
CNP nvarchar(14) NOT NULL,
TipActId int REFERENCES TipAct(TipActId),
Serie NVARCHAR(3) NOT NULL,
Numar NVARCHAR(6) NOT NULL,
Adresa TEXT
)

CREATE TABLE Contract
(
ContractId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NrContract NVARCHAR(4) NOT NULL,
Data DATE NOT NULL,
BeneficiarId int REFERENCES Beneficiar (BeneficiarId),
[ObiectulContractului] TEXT not null,
Suma DECIMAL NOT NULL,
Observatii TEXT
)

CREATE TABLE Factura
(
 FacturaId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
 [SerieFactura] NVARCHAR(4) NOT NULL,
 [Nr.Factura] NVARCHAR(6) NOT NULL,
 [DataFactura] DATE NOT NULL,
 Suma DECIMAL NOT NULL,
 ContractId INT REFERENCES Contract (ContractId),
 Plata bit Not Null,
 [PlatitorTVA] bit Not Null 
)

CREATE TABLE Chitanta
(
	ChitantaId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[SerieChitanta] NVARCHAR(4) NOT NULL,
	[Nr.Chitanta] NVARCHAR (6) NOT NULL,
	[DataEmiterii] DATE NOT NULL,
	FacturaId INT NOT NULL REFERENCES Factura (FacturaId)
)

CREATE TABLE Lucrare
(
LucrareId INT NOT NULL Identity(1,1) PRIMARY KEY,
AcceptataRefuzataId INT NOT NULL REFERENCES AcceptataRefuzata(AcceptataRefuzataId),
[Nr.OCPI]              nvarchar(10),
[DataInregistrare]    DATE,
[TermenSolutionare]   DATE,          
[AvizatorRegistrator] TEXT,         
TipLucrareId INT REFERENCES TipLucrare (TipLucrareId), 
[Nr.Proiect] NVARCHAR(6) NOT NULL,
[AnProiect] NVARCHAR(4) NOT NULL,
ContractId INT REFERENCES Contract (ContractId),
[Cad/Top] TEXT NOT NULL,
UAT NVARCHAR(100) NOT NULL,
Observatii TEXT NULL,
ReceptionatRespinsId  INT NOT NULL REFERENCES ReceptionatRespins(ReceptionatRespinsId),
)
