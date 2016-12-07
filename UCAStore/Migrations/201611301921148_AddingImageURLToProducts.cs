namespace UCAStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingImageURLToProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImageUrl");
        }
    }
}
