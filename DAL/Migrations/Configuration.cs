namespace DAL.Migrations
{
    using DAL.EF.Tables;
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


            //seed nethidf for user data

            //for (int i = 0; i < 20; i++)
            //{
            //    context.Users.AddOrUpdate(new EF.Tables.User
            //    {
            //        Name = "Name" + i,
            //        Password = "Password" + i,
            //        Email="example"+i+"@email.com",
            //        Role = i % 2 == 0 ? "Admin" : "User",
            //        Address = "Address " + i,
            //        CreatedAt = DateTime.Now.AddDays(-i)
            //    });
            //}

            //seed for product data

            //var userIds = context.Users.Select(u => u.Id).ToList();

            //for (int i = 0; i < 50; i++)
            //{
            //    context.Products.AddOrUpdate(new EF.Tables.Product
            //    {
            //        Name = "Product " + i,
            //        Description = "Description for product " + i,
            //        Price = (decimal)Math.Round(new Random().Next(100, 1000) + new Random().NextDouble(), 2),
            //        Stock = new Random().Next(1, 50),
            //        Category = i % 2 == 0 ? "Electronics" : "Clothing",
            //        SellerId = userIds[i % userIds.Count],
            //        CreatedAt = DateTime.Now.AddDays(-i)
            //    });
            //}

            //seed for order and order item data
            //var userIds=context.Users.Select(u=>u.Id).ToList();
            //var productIds=context.Products.Select(p=>p.Id).ToList();

            //for(int i = 0; i < 20; i++)
            //{
            //    context.
            //}
        }
    }
}
