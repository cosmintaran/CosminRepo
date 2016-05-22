namespace Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facturi_chitante : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factura", "NrFactura", c => c.String(nullable: false, maxLength: 6));
            AddColumn("dbo.Factura", "Pret + T.V.A.", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AddColumn("dbo.Factura", "Valoare T.V.A.", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Factura", "Achizitie/Vanzare", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factura", "Plateste T.V.A", c => c.Boolean(nullable: false));
            AddColumn("dbo.Chitanta", "Plata Numerar", c => c.Boolean(nullable: false));
            DropColumn("dbo.Factura", "Nr.Factura");
            DropColumn("dbo.Factura", "Suma");
            DropColumn("dbo.Factura", "Plata");
            DropColumn("dbo.Factura", "PlatitorTVA");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Factura", "PlatitorTVA", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factura", "Plata", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factura", "Suma", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AddColumn("dbo.Factura", "Nr.Factura", c => c.String(nullable: false, maxLength: 6));
            DropColumn("dbo.Chitanta", "Plata Numerar");
            DropColumn("dbo.Factura", "Plateste T.V.A");
            DropColumn("dbo.Factura", "Achizitie/Vanzare");
            DropColumn("dbo.Factura", "Valoare T.V.A.");
            DropColumn("dbo.Factura", "Pret + T.V.A.");
            DropColumn("dbo.Factura", "NrFactura");
        }
    }
}
