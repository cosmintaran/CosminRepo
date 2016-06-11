namespace Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcceptataRefuzata",
                c => new
                    {
                        AcceptataRefuzataId = c.Int(nullable: false, identity: true),
                        StatusAccept = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.AcceptataRefuzataId);
            
            CreateTable(
                "dbo.Lucrare",
                c => new
                    {
                        LucrareId = c.Int(nullable: false, identity: true),
                        AcceptataRefuzataId = c.Int(nullable: false),
                        NrOCPI = c.String(name: "Nr.OCPI", maxLength: 10),
                        DataInregistrare = c.DateTime(storeType: "date"),
                        TermenSolutionare = c.DateTime(storeType: "date"),
                        AvizatorRegistrator = c.String(unicode: false, storeType: "text"),
                        TipLucrareId = c.Int(),
                        NrProiect = c.String(name: "Nr.Proiect", nullable: false, maxLength: 6),
                        AnProiect = c.String(nullable: false, maxLength: 4),
                        ContractId = c.Int(),
                        CadTop = c.String(name: "Cad/Top", nullable: false, unicode: false, storeType: "text"),
                        UAT = c.String(nullable: false, maxLength: 100),
                        Observatii = c.String(unicode: false, storeType: "text"),
                        ReceptionatRespinsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LucrareId)
                .ForeignKey("dbo.Contract", t => t.ContractId)
                .ForeignKey("dbo.ReceptionatRespins", t => t.ReceptionatRespinsId)
                .ForeignKey("dbo.TipLucrare", t => t.TipLucrareId)
                .ForeignKey("dbo.AcceptataRefuzata", t => t.AcceptataRefuzataId)
                .Index(t => t.AcceptataRefuzataId)
                .Index(t => t.TipLucrareId)
                .Index(t => t.ContractId)
                .Index(t => t.ReceptionatRespinsId);
            
            CreateTable(
                "dbo.Contract",
                c => new
                    {
                        ContractId = c.Int(nullable: false, identity: true),
                        NrContract = c.String(nullable: false, maxLength: 4),
                        Data = c.DateTime(nullable: false, storeType: "date"),
                        BeneficiarId = c.Int(),
                        ObiectulContractului = c.String(nullable: false, unicode: false, storeType: "text"),
                        Suma = c.Decimal(nullable: false, precision: 18, scale: 0),
                        Observatii = c.String(unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.ContractId)
                .ForeignKey("dbo.Beneficiar", t => t.BeneficiarId)
                .Index(t => t.BeneficiarId);
            
            CreateTable(
                "dbo.Beneficiar",
                c => new
                    {
                        BeneficiarId = c.Int(nullable: false, identity: true),
                        Nume = c.String(nullable: false, maxLength: 150),
                        CNP = c.String(nullable: false, maxLength: 14),
                        TipActId = c.Int(),
                        Serie = c.String(maxLength: 3),
                        Numar = c.String(maxLength: 6),
                        Adresa = c.String(unicode: false, storeType: "text"),
                        AtributFiscal = c.String(maxLength: 3),
                        NrRegComert = c.String(maxLength: 25),
                        Telefon = c.String(maxLength: 14),
                        AdresaEmail = c.String(maxLength: 50),
                        PersoanaFizica = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BeneficiarId)
                .ForeignKey("dbo.TipAct", t => t.TipActId)
                .Index(t => t.TipActId);
            
            CreateTable(
                "dbo.TipAct",
                c => new
                    {
                        TipActId = c.Int(nullable: false, identity: true),
                        TipAct = c.String(nullable: false, maxLength: 22),
                    })
                .PrimaryKey(t => t.TipActId);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        FacturaId = c.Int(nullable: false, identity: true),
                        SerieFactura = c.String(nullable: false, maxLength: 4),
                        NrFactura = c.String(nullable: false, maxLength: 6),
                        DataFactura = c.DateTime(nullable: false, storeType: "date"),
                        PretTVA = c.Decimal(name: "Pret + T.V.A.", nullable: false, precision: 18, scale: 0),
                        ValoareTVA = c.Decimal(name: "Valoare T.V.A.", nullable: false, precision: 18, scale: 2),
                        AchizitieVanzare = c.Boolean(name: "Achizitie/Vanzare", nullable: false),
                        PlatesteTVA = c.Boolean(name: "Plateste T.V.A", nullable: false),
                        ContractId = c.Int(),
                    })
                .PrimaryKey(t => t.FacturaId)
                .ForeignKey("dbo.Contract", t => t.ContractId)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.Chitanta",
                c => new
                    {
                        ChitantaId = c.Int(nullable: false, identity: true),
                        SerieChitanta = c.String(nullable: false, maxLength: 4),
                        NrChitanta = c.String(name: "Nr.Chitanta", nullable: false, maxLength: 6),
                        DataEmiterii = c.DateTime(nullable: false, storeType: "date"),
                        PlataNumerar = c.Boolean(name: "Plata Numerar", nullable: false),
                        FacturaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChitantaId)
                .ForeignKey("dbo.Factura", t => t.FacturaId)
                .Index(t => t.FacturaId);
            
            CreateTable(
                "dbo.ReceptionatRespins",
                c => new
                    {
                        ReceptionatRespinsId = c.Int(nullable: false, identity: true),
                        StatusRec = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.ReceptionatRespinsId);
            
            CreateTable(
                "dbo.TipLucrare",
                c => new
                    {
                        TipLucrareId = c.Int(nullable: false, identity: true),
                        CodLucrare = c.String(nullable: false, maxLength: 5),
                        TipLucrare = c.String(nullable: false, maxLength: 125),
                    })
                .PrimaryKey(t => t.TipLucrareId);
            
            CreateTable(
                "dbo.Judet",
                c => new
                    {
                        JudetId = c.Int(nullable: false, identity: true),
                        DenumireJudet = c.String(name: "Denumire Judet", nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.JudetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lucrare", "AcceptataRefuzataId", "dbo.AcceptataRefuzata");
            DropForeignKey("dbo.Lucrare", "TipLucrareId", "dbo.TipLucrare");
            DropForeignKey("dbo.Lucrare", "ReceptionatRespinsId", "dbo.ReceptionatRespins");
            DropForeignKey("dbo.Lucrare", "ContractId", "dbo.Contract");
            DropForeignKey("dbo.Factura", "ContractId", "dbo.Contract");
            DropForeignKey("dbo.Chitanta", "FacturaId", "dbo.Factura");
            DropForeignKey("dbo.Beneficiar", "TipActId", "dbo.TipAct");
            DropForeignKey("dbo.Contract", "BeneficiarId", "dbo.Beneficiar");
            DropIndex("dbo.Chitanta", new[] { "FacturaId" });
            DropIndex("dbo.Factura", new[] { "ContractId" });
            DropIndex("dbo.Beneficiar", new[] { "TipActId" });
            DropIndex("dbo.Contract", new[] { "BeneficiarId" });
            DropIndex("dbo.Lucrare", new[] { "ReceptionatRespinsId" });
            DropIndex("dbo.Lucrare", new[] { "ContractId" });
            DropIndex("dbo.Lucrare", new[] { "TipLucrareId" });
            DropIndex("dbo.Lucrare", new[] { "AcceptataRefuzataId" });
            DropTable("dbo.Judet");
            DropTable("dbo.TipLucrare");
            DropTable("dbo.ReceptionatRespins");
            DropTable("dbo.Chitanta");
            DropTable("dbo.Factura");
            DropTable("dbo.TipAct");
            DropTable("dbo.Beneficiar");
            DropTable("dbo.Contract");
            DropTable("dbo.Lucrare");
            DropTable("dbo.AcceptataRefuzata");
        }
    }
}
