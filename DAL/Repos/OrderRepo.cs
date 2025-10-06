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
    internal class OrderRepo : IRepo<Order,int,bool>,IOrderFeature
    {
        MarketContext db;

        public OrderRepo()
        {
            db = new MarketContext();
        }
        public bool Create(Order obj)
        {
            db.Orders.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var order=Get(id);
            if (order != null)
            {
                order.Status = "Cancelled";
                return db.SaveChanges() > 0;
            }
            else return false;
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public List<Order> GetOrdersByBuyerId(int buyerId)
        {
            var orders = (from o in db.Orders where o.BuyerId == buyerId select o).ToList();
            return orders;
        }

        public bool Update(Order obj)
        {
            var extOrder=Get(obj.Id);
            if(extOrder != null)
            {
                extOrder.Status=obj.Status;
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
