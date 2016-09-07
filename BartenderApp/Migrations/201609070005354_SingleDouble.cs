namespace BartenderApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SingleDouble : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SingleDouble", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "SingleDouble");
        }
    }
}
