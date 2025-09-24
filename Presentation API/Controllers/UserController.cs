using BLL.DTOs;
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
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {
            var user=UserService.GetUser(id);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, user);
        }
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage Create(UserDTO obj)
        {
            var newUser = UserService.CreateUser(obj);
            return Request.CreateResponse(System.Net.HttpStatusCode.Created, newUser);
        }
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage Update(UserDTO obj)
        {
            var user=UserService.UpdateUser(obj);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, user);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var result=UserService.DeleteUser(id);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, result);
        }
    }
}