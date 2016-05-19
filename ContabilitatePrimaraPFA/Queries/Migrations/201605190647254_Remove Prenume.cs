namespace Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePrenume : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Beneficiar", "Nume", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.Beneficiar", "Prenume");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beneficiar", "Prenume", c => c.String(maxLength: 50));
            AlterColumn("dbo.Beneficiar", "Nume", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
