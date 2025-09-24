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
    public class ProductService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDTO>().ReverseMap();
            });
            return new Mapper(config);
        }
        //getting all the products
        public static List<ProductDTO> GetProduct()
        {
            var products = DataAccessFactory.ProductData().Get();
            return GetMapper().Map<List<ProductDTO>>(products);
        }

        //getting products based on the id
        public static ProductDTO GetProduct(int id)
        {
            var product=DataAccessFactory.ProductData().Get(id);
            return GetMapper().Map<ProductDTO>(product);
        }

        //creating new product
        public static bool CreateProduct(ProductDTO obj)
        {
            var product=GetMapper().Map<Product>(obj);
            return DataAccessFactory.ProductData().Create(product);
        }
    }
}
