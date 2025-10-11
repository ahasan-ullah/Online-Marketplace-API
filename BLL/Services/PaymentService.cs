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
        public static List<PaymentDTO> GetPayment()
        {
            var payments = DataAccessFactory.PaymentData().Get();
            return GetMapper().Map<List<PaymentDTO>>(payments);
        }
        public static PaymentDTO GetPayment(int id)
        {
            var payment=DataAccessFactory.PaymentData().Get(id);
            return GetMapper().Map<PaymentDTO>(payment);
        }
        public static bool UpdatePayment(PaymentDTO obj)
        {
            var payment= GetMapper().Map<Payment>(obj);
            return DataAccessFactory.PaymentData().Update(payment);
        }
    }
}
