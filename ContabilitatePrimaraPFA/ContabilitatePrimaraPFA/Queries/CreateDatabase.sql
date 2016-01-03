
CREATE TABLE Judete
(
ID_Judet smallint NOT NULL IDENTITY(1,1) PRIMARY KEY,
[Denumire Judet] nvarchar(15) NOT NULL
)

INSERT INTO Judete VALUES ('Alba')
INSERT INTO Judete VALUES ('Arad')
INSERT INTO Judete VALUES ('Arges')
INSERT INTO Judete VALUES ('Bacau')
INSERT INTO Judete VALUES ('Bihor')
INSERT INTO Judete VALUES ('Bistrita-Nasaud')
INSERT INTO Judete VALUES ('Botosani')
INSERT INTO Judete VALUES ('Braila')
INSERT INTO Judete VALUES ('Brasov')
INSERT INTO Judete VALUES ('Bucuresti')
INSERT INTO Judete VALUES ('Buzau')
INSERT INTO Judete VALUES ('Calarasi')
INSERT INTO Judete VALUES ('Caras-Severin')
INSERT INTO Judete VALUES ('Cluj')
INSERT INTO Judete VALUES ('Constanta')
INSERT INTO Judete VALUES ('Covasna')
INSERT INTO Judete VALUES ('Dambovita')
INSERT INTO Judete VALUES ('Dolj')
INSERT INTO Judete VALUES ('Galati')
INSERT INTO Judete VALUES ('Giurgiu')
INSERT INTO Judete VALUES ('Gorj')
INSERT INTO Judete VALUES ('Harghita')
INSERT INTO Judete VALUES ('Hunedoara')
INSERT INTO Judete VALUES ('Ialomita')
INSERT INTO Judete VALUES ('Iasi')
INSERT INTO Judete VALUES ('Ilfov')
INSERT INTO Judete VALUES ('Maramures')
INSERT INTO Judete VALUES ('Mehedinti')
INSERT INTO Judete VALUES ('Mures')
INSERT INTO Judete VALUES ('Neamt')
INSERT INTO Judete VALUES ('Olt')
INSERT INTO Judete VALUES ('Prahova')
INSERT INTO Judete VALUES ('Salaj')
INSERT INTO Judete VALUES ('Satu-Mare')
INSERT INTO Judete VALUES ('Sibiu')
INSERT INTO Judete VALUES ('Suceava')
INSERT INTO Judete VALUES ('Teleorman')
INSERT INTO Judete VALUES ('Timis')
INSERT INTO Judete VALUES ('Valcea')
INSERT INTO Judete VALUES ('Vaslui')
INSERT INTO Judete VALUES ('Vrancea')

CREATE TABLE RecRes
(
ID_RecRes TINYINT NOT NULL Identity(1,1) PRIMARY KEY,
Status NVARCHAR(11) NOT NULL 
)

INSERT INTO RecRes VALUES('Receptionat')
INSERT INTO RecRes VALUES('Respins')

CREATE TABLE AcceptRefuz
(
ID_AcceptRefuz TINYINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Status nvarchar(10) NOT NULL
)
INSERT INTO AcceptRefuz VALUES('Acceptata')
INSERT INTO AcceptRefuz VALUES('Refuzata')

CREATE TABLE TipLucrari
(
ID_TipLucrari INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
[Cod Lucrare] nvarchar(5) NOT NULL,
[Tip Lucrare] nvarchar(125) NOT NULL
)

INSERT INTO TipLucrari VALUES('1.1.1','Aviz incepere lucrari')
INSERT INTO TipLucrari VALUES('1.1.2','Receptie tehnica pentru lucrari de masuratori terestre')
INSERT INTO TipLucrari VALUES('2.1.1','Receptie si infiintare carte funciara')
INSERT INTO TipLucrari VALUES('2.1.2','Receptie (nr. cadastral)')
INSERT INTO TipLucrari VALUES('2.1.3','Infiintare carte funciara')
INSERT INTO TipLucrari VALUES('2.2.1','Receptie dezmembrare / comasare')
INSERT INTO TipLucrari VALUES('2.2.2','Inscriere dezmembrare / comasare in cartea funciara')
INSERT INTO TipLucrari VALUES('2.2.3','Dezmembrare pentru exproprieri')
INSERT INTO TipLucrari VALUES('2.5.1','Indreptare eroare materiala si repozitionare imobil')
INSERT INTO TipLucrari VALUES('2.5.2','Rectificare limite imobil si modificare suprafata')
INSERT INTO TipLucrari VALUES('2.5.3','Reconstituire carte funciara')
INSERT INTO TipLucrari VALUES('2.6.1','Inscriere constructii')
INSERT INTO TipLucrari VALUES('2.6.2','Extindere sau desfiintare constructii si actualizare categorie de folosinta, destinatie sau alte informatii tehnice')


CREATE TABLE TipActe
(
ID tinyint NOT NULL IDENTITY(1,1) PRIMARY KEY,
TipAct NVARCHAR(22) not null
)
INSERT INTO TipActe(TipAct) Values ('Buletin de Identitate');
INSERT INTO TipActe (TipAct) Values ('Carte de Identitate');
INSERT INTO TipActe (TipAct) Values ('Pasaport');

CREATE TABLE Beneficiari 
(ID_Beneficiar bigint NOT NULL Identity(1,1) Primary Key,
Nume NVARCHAR(40) NOT NULL,
Prenume NVARCHAR(50) NOT NULL,
CNP NVARCHAR(13) NOT NULL,
[Tip Act] tinyint REFERENCES TipActe(ID),
Serie NVARCHAR(3) NOT NULL,
Numar NVARCHAR(5) NOT NULL,
Adresa TEXT
)

CREATE TABLE Contracte
(
ID_Contract BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
NrContract NVARCHAR(4) NOT NULL,
Data DATE NOT NULL,
Beneficiar_ID bigint REFERENCES Beneficiari(ID_Beneficiar),
[Scopul/Obiectul Contractului] TEXT not null,
UAT NVARCHAR(100) NOT NULL,
Suma DECIMAL NOT NULL,
Observatii TEXT
)

CREATE TABLE Incasari
(
ID_Incasari BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
 [Nr. Factura] NVARCHAR(4) NOT NULL,
 [Data Factura] DATE NOT NULL,
 Suma DECIMAL NOT NULL,
 [Contract] BIGINT REFERENCES Contracte(ID_Contract)
)

CREATE TABLE Lucrari
(
ID_Lucrare BIGINT NOT NULL Identity(1,1) PRIMARY KEY,
[Acceptata/Refuzata] TINYINT NOT NULL REFERENCES AcceptRefuz(ID_AcceptRefuz),
[Nr_OCPI]              INT           NOT NULL,
[Data_inregistrare]    DATE          NOT NULL,
[Termen_Solutionare]   DATE,          
[Avizator_Registrator] TEXT,         
[Tip_Lucrare] INT REFERENCES TipLucrari(ID_TipLucrari), 
[Nr. Proiect] NVARCHAR(3) NOT NULL,
[An Proiect] NVARCHAR(4) NOT NULL,
[Contract] BIGINT REFERENCES Contracte(ID_Contract),
[Receptionat/Respins] TINYINT REFERENCES RecRes(ID_RecRes)
)
