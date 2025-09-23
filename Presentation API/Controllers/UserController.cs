using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Presentation_API.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController:ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage Get()
        {
            var users = UserService.GetUser();
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, users);
        }
    }
}