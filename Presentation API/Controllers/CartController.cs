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
    [RoutePrefix("api/cart")]
    public class CartController:ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetCart()
        {
            var result = CartService.GetCart();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}