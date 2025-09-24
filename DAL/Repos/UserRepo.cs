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
            db.Users.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
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
            var extuser = Get(obj.Id);

            if (extuser!=null)
            {
                extuser.Name = obj.Name;
                extuser.Email = obj.Email;
                extuser.Password = obj.Password;
                extuser.Address = obj.Address;
                extuser.IsActive=obj.IsActive;
                return db.SaveChanges()>0;
            } 
            return false;
        }
    }
}
