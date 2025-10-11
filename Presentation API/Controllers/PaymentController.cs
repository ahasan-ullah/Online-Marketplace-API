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
    [RoutePrefix("api/payment")]
    public class PaymentController:ApiController
    {
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreatePayment(PaymentDTO obj)
        {
            var result = PaymentService.CreatePayment(obj);
            return Request.CreateResponse(HttpStatusCode.OK, "Payment Created");
        }
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetPayment()
        {
            var result = PaymentService.GetPayment();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}