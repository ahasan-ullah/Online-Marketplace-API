namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isdeleteattribteaddedtoprodcuttable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "isDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "isDeleted");
        }
    }
}
