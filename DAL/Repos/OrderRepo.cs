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
    internal class OrderRepo : IRepo<Order,int,bool>
    {
        MarketContext db;

        public OrderRepo()
        {
            db = new MarketContext();
        }
        public bool Create(Order obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public bool Update(Order obj)
        {
            throw new NotImplementedException();
        }
    }
}
