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
            var carts = DataAccessFactory.CartData().Get();
            return GetMapper().Map<List<CartDTO>>(carts);
        }
        public static CartDTO GetCart(int id)
        {
            var cart = DataAccessFactory.CartData().Get(id);
            return GetMapper().Map<CartDTO>(cart);
        }
        public static bool CreateCart(CartDTO obj)
        {
            var cart = GetMapper().Map<Cart>(obj);
            return DataAccessFactory.CartData().Create(cart);
        }
        public static bool UpdateCart(CartItemDTO obj)
        {
            var cartItems = GetMapper().Map<CartItem>(obj);
            return DataAccessFactory.CartFeature().UpdateCartItem(cartItems);
        }
        public static bool DeleteCart(int id)
        {
            return DataAccessFactory.CartData().Delete(id);
        }
    }
}
