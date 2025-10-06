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
    internal class CartRepo : IRepo<Cart, int, bool>
    {
        MarketContext db;
        public CartRepo()
        {
            db=new MarketContext();
        }
        public bool Create(Cart obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cart> Get()
        {
            return db.Carts.ToList();
        }

        public Cart Get(int id)
        {
            return db.Carts.Find(id);
        }

        public bool Update(Cart obj)
        {
            throw new NotImplementedException();
        }
    }
}
