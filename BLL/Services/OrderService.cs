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
    public class OrderService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderDTO>().ReverseMap();
                cfg.CreateMap<OrderItem, OrderItemDTO>().ReverseMap();
            });
            return new Mapper(config);
        }

        public static List<OrderDTO> GetOrder()
        {
            var orders=DataAccessFactory.OrderData().Get();
            return GetMapper().Map<List<OrderDTO>>(orders);
        }

        public static OrderDTO GetOrder(int id)
        {
            var order=DataAccessFactory.OrderData().Get(id);
            return GetMapper().Map<OrderDTO>(order);
        }
    }
}
