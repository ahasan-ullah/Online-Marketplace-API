using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Net;
using BLL.DTOs;

namespace Presentation_API.Controllers
{
    [RoutePrefix("api/order")]
    public class OrderController:ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetOrder()
        {
            var orders = OrderService.GetOrder();
            return Request.CreateResponse(HttpStatusCode.OK, orders);
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetOrder(int id)
        {
            var order=OrderService.GetOrder(id);
            return Request.CreateResponse(HttpStatusCode.OK,order);
        }
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreateOrder(OrderDTO obj)
        {
            var result=OrderService.CreateOrder(obj);
            return Request.CreateResponse(HttpStatusCode.OK,"Order placed successfully");
        }
    }
}