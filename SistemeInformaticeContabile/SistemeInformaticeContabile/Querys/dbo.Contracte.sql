CREATE TABLE [dbo].[Contracte] (
    [Id]                    INT         IDENTITY (1, 1) NOT NULL,
    [Nr_Contract]           INT         NOT NULL,
    [Data_Contract]         DATE        NOT NULL,
    [Beneficiar]            INT      references Beneficiari(Id)   NOT NULL ,
	[Procese Verbale] int references ProceseVerbale(Nr_Inregistrare),
	[Incasari] int references Incasari(Id),
    [Obiectul_Contractului] TEXT        NOT NULL,
    [UAT]                   VARCHAR (50) NOT NULL,
    [Valoare]               MONEY       NOT NULL,
    [Observatii]            TEXT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

