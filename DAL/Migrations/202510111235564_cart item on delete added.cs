namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartitemondeleteadded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CartItems", "ProductId", "dbo.Products");
            AddForeignKey("dbo.CartItems", "ProductId", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "ProductId", "dbo.Products");
            AddForeignKey("dbo.CartItems", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
