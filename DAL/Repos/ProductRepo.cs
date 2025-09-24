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

        public bool Delete(int iD)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
