CREATE TABLE [dbo].[RegistruEvidenteLucrari] (
    [Id]                   INT           IDENTITY (1, 1) NOT NULL,
    [Acceptata_Respinsa]   INT           NULL,
    [Nr_OCPI]              INT           NOT NULL,
    [Data_inregistrare]    DATE          NOT NULL,
    [Termen_Solutionare]   DATE          NULL,
    [Avizator_Registrator] TEXT          NULL,
    [Tip_Lucrare]          varchar(5)    not NULL,
    [Nr_proiect]           VARCHAR (3)   NOT NULL,
    [An_Proiect]           VARCHAR (4)   NOT NULL,
    [Nr_Cad_Top]           VARCHAR (100) NOT NULL,
    [UAT]                  VARCHAR (25)  NOT NULL,
    [Nr_Contract]          INT           NULL,
    [Receptionat_Respins]  INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Acceptata_Respinsa]) REFERENCES [dbo].[Respins_Acceptat] ([ID]),
    FOREIGN KEY ([Nr_Contract]) REFERENCES [dbo].[Contracte] ([Id]),
    FOREIGN KEY ([Receptionat_Respins]) REFERENCES [dbo].[Respins_Acceptat] ([ID]),
    FOREIGN KEY ([Tip_Lucrare]) REFERENCES [dbo].[Lucrare] ([Id])
);

