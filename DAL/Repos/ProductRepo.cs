using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductRepo:IRepo<Product,int,bool>
    {
        MarketContext db;
        public ProductRepo()
        {
            db = new MarketContext();
        }

        public bool Create(Product obj)
        {
            db.Products.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var orderPId=db.OrderItems.Where(oi=>oi.Id==id);
            var cartPId=db.CartItems.Where(ci=>ci.Id==id);
            var product=Get(id);
            if (orderPId != null && cartPId!=null)
            {
                product.isDeleted = true;
                return db.SaveChanges() > 0;
            }
            db.Products.Remove(product);
            return db.SaveChanges() > 0;
        }

        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public bool Update(Product obj)
        {
            var product = Get(obj.Id);
            if(product != null)
            {
                product.Name = obj.Name;
                product.Description = obj.Description;
                product.Price=obj.Price;
                product.Stock = obj.Stock;
                product.Category= obj.Category;

                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
