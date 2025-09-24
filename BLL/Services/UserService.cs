using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>().ReverseMap();
            });
            return new Mapper(config);
        }
        //getting all user list
        public static List<UserDTO> GetUser()
        {
            var users = DataAccessFactory.UserData().Get();

            return GetMapper().Map<List<UserDTO>>(users);
        }

        //getting single user by by
        public static UserDTO GetUser(int id)
        {
            var user = DataAccessFactory.UserData().Get(id);
            return GetMapper().Map<UserDTO>(user);
        }

        //creating new user
        public static bool CreateUser(UserDTO obj)
        {
            var users = DataAccessFactory.UserData().Get(); 
            var extuser=from u in users where u.Email == obj.Email select u;

            if(extuser == null)
            {
                var user = GetMapper().Map<User>(obj);
                return DataAccessFactory.UserData().Create(user);
            }
            return false;
        }

        //update an exsiting user
        public static bool UpdateUser(UserDTO obj)
        {
            var user=GetMapper().Map<User>(obj);
            return DataAccessFactory.UserData().Update(user);
        }
    }
}
