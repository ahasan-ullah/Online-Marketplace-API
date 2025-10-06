using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

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
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, orders);
        }
    }
}