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
    internal class UserRepo:IRepo<User,int,bool>
    {
        MarketContext db;
        public UserRepo()
        {
            db =new MarketContext();
        }

        public bool Create(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int iD)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
