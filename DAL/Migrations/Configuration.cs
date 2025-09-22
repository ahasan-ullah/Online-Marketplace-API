namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Reflection;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.MarketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.MarketContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            //for (int i = 0; i < 20; i++)
            //{
            //    context.Users.AddOrUpdate(new EF.Tables.User
            //    {
            //        Name = "Name" + i,
            //        Password = "Password" + i,
            //        Role = i % 2 == 0 ? "Admin" : "User",
            //        Address = "Address " + i,
            //        CreatedAt = DateTime.Now.AddDays(-i)
            //    });
            //}
        }
    }
}
