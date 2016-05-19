namespace Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Persoanafizica : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beneficiar", "PersoanaFizica", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Beneficiar", "PersoanaFizica");
        }
    }
}
