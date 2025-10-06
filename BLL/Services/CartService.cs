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
    public class CartService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cart, CartDTO>().ReverseMap();
                cfg.CreateMap<CartItem, CartItemDTO>().ReverseMap();
            });
            return new Mapper(config);
        }
        public static List<CartDTO> GetCart()
        {
            var cart = DataAccessFactory.CartData().Get();
            return GetMapper().Map<List<CartDTO>>(cart);
        }
    }
}
