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
    }
}
