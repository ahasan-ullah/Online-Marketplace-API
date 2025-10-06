using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Presentation_API.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage Get()
        {
            var products = ProductService.GetProduct();
            return Request.CreateResponse(HttpStatusCode.OK, products);
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {
            var product=ProductService.GetProduct(id);
            return Request.CreateResponse(HttpStatusCode.OK,product);
        }
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage Create(ProductDTO obj)
        {
            var result=ProductService.CreateProduct(obj);
            return Request.CreateResponse(HttpStatusCode.OK, "Product Created Successfully");
        }
        [HttpPatch]
        [Route("update")]
        public HttpResponseMessage Update(ProductDTO obj)
        {
            var result= ProductService.UpdateProduct(obj);
            return Request.CreateResponse(HttpStatusCode.OK, "Product updated succressfully");
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var result=ProductService.DeleteProduct(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Product Deleted Successfully");
        }
    }
}