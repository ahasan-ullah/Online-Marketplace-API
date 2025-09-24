using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, products);
        }
    [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {
            var product=ProductService.GetProduct(id);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK,product);
        }
    }
}