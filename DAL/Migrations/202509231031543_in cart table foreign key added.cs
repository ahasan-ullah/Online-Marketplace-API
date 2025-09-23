namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class incarttableforeignkeyadded : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Carts", "BuyerId");
            AddForeignKey("dbo.Carts", "BuyerId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "BuyerId", "dbo.Users");
            DropIndex("dbo.Carts", new[] { "BuyerId" });
        }
    }
}
