namespace BartenderApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDrinkTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DrinkTypes (Id, DrinkCost, NumberOfDrinks,DiscountRate) VALUES(1,5,2,0)");
            Sql("INSERT INTO DrinkTypes (Id, DrinkCost, NumberOfDrinks,DiscountRate) VALUES(2,3,3,0)");
            Sql("INSERT INTO DrinkTypes (Id, DrinkCost, NumberOfDrinks,DiscountRate) VALUES(3,8,1,0)");
            Sql("INSERT INTO DrinkTypes (Id, DrinkCost, NumberOfDrinks,DiscountRate) VALUES(4,12,1,0)");
        }
        
        public override void Down()
        {
        }
    }
}
