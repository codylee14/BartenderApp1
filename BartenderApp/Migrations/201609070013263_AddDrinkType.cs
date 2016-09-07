namespace BartenderApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDrinkType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DrinkTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DrinkCost = c.Short(nullable: false),
                        NumberOfDrinks = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "DrinkTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "DrinkTypeId");
            AddForeignKey("dbo.Customers", "DrinkTypeId", "dbo.DrinkTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "DrinkTypeId", "dbo.DrinkTypes");
            DropIndex("dbo.Customers", new[] { "DrinkTypeId" });
            DropColumn("dbo.Customers", "DrinkTypeId");
            DropTable("dbo.DrinkTypes");
        }
    }
}
