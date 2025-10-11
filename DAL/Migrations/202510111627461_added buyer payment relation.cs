namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedbuyerpaymentrelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "BuyerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Payments", "BuyerId");
            AddForeignKey("dbo.Payments", "BuyerId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "BuyerId", "dbo.Users");
            DropIndex("dbo.Payments", new[] { "BuyerId" });
            DropColumn("dbo.Payments", "BuyerId");
        }
    }
}
