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
    internal class PaymentRepo : IRepo<Payment,int,bool>
    {
        MarketContext db;
        public PaymentRepo()
        {
            db=new MarketContext();
        }
        public bool Create(Payment obj)
        {
            db.Payments.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Payment> Get()
        {
            return db.Payments.ToList();
        }

        public Payment Get(int id)
        {
            return db.Payments.Find(id);
        }

        public bool Update(Payment obj)
        {
            throw new NotImplementedException();
        }
    }
}
