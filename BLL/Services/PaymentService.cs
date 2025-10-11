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
    public class PaymentService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Payment, PaymentDTO>().ReverseMap();
            });
            return new Mapper(config);
        }
        
        public static bool CreatePayment(PaymentDTO obj)
        {
            var payment=GetMapper().Map<Payment>(obj);
            return DataAccessFactory.PaymentData().Create(payment);
        }
    }
}
