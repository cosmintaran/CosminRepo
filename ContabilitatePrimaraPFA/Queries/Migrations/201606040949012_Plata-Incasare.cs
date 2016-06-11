namespace Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlataIncasare : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Chitanta", "FacturaId", "dbo.Factura");
            DropForeignKey("dbo.Factura", "ContractId", "dbo.Contract");
            DropIndex("dbo.Factura", new[] { "ContractId" });
            DropIndex("dbo.Chitanta", new[] { "FacturaId" });
            CreateTable(
                "dbo.Incasari",
                c => new
                    {
                        IncasareId = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        TipDocument = c.String(nullable: false, maxLength: 16),
                        Serie = c.String(nullable: false, maxLength: 6),
                        NumarDocument = c.String(name: "Numar Document", nullable: false),
                        Suma = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransferBancar = c.Boolean(nullable: false),
                        PlatesteTVA = c.Boolean(name: "Plateste T.V.A", nullable: false),
                        ValoareTVA = c.Decimal(name: "Valoare T.V.A.", nullable: false, precision: 18, scale: 2),
                        SumaTVA = c.Decimal(name: "Suma T.V.A.", nullable: false, precision: 18, scale: 2),
                        ContractId = c.Int(),
                        FelulOperatiunii = c.String(name: "Felul Operatiunii", nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.IncasareId)
                .ForeignKey("dbo.Contract", t => t.ContractId)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.Plati",
                c => new
                    {
                        PlataId = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        TipDocument = c.String(nullable: false, maxLength: 16),
                        Serie = c.String(nullable: false, maxLength: 6),
                        NumarDocument = c.String(name: "Numar Document", nullable: false),
                        Suma = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransferBancar = c.Boolean(nullable: false),
                        PlatesteTVA = c.Boolean(name: "Plateste T.V.A", nullable: false),
                        ValoareTVA = c.Decimal(name: "Valoare T.V.A.", nullable: false, precision: 18, scale: 2),
                        SumaTVA = c.Decimal(name: "Suma T.V.A.", nullable: false, precision: 18, scale: 2),
                        ContractId = c.Int(),
                        FelulOperatiunii = c.String(name: "Felul Operatiunii", nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.PlataId)
                .ForeignKey("dbo.Contract", t => t.ContractId)
                .Index(t => t.ContractId);
            
            DropTable("dbo.Factura");
            DropTable("dbo.Chitanta");
            DropTable("dbo.Judet");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Judet",
                c => new
                    {
                        JudetId = c.Int(nullable: false, identity: true),
                        DenumireJudet = c.String(name: "Denumire Judet", nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.JudetId);
            
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
                .PrimaryKey(t => t.ChitantaId);
            
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
                .PrimaryKey(t => t.FacturaId);
            
            DropForeignKey("dbo.Plati", "ContractId", "dbo.Contract");
            DropForeignKey("dbo.Incasari", "ContractId", "dbo.Contract");
            DropIndex("dbo.Plati", new[] { "ContractId" });
            DropIndex("dbo.Incasari", new[] { "ContractId" });
            DropTable("dbo.Plati");
            DropTable("dbo.Incasari");
            CreateIndex("dbo.Chitanta", "FacturaId");
            CreateIndex("dbo.Factura", "ContractId");
            AddForeignKey("dbo.Factura", "ContractId", "dbo.Contract", "ContractId");
            AddForeignKey("dbo.Chitanta", "FacturaId", "dbo.Factura", "FacturaId");
        }
    }
}
