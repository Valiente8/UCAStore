namespace UCAStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMaxs : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 70));
        }
    }
}
