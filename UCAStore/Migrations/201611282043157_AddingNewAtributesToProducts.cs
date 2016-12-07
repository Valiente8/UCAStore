namespace UCAStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewAtributesToProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Color", c => c.String());
            AddColumn("dbo.Products", "Weight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Weight");
            DropColumn("dbo.Products", "Color");
        }
    }
}
