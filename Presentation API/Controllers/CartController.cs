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
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetCart(int id)
        {
            var result = CartService.GetCart(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreateCart(CartDTO obj)
        {
            var result = CartService.CreateCart(obj);
            return Request.CreateResponse(HttpStatusCode.OK, "Product added to cart");
        }
        [HttpPatch]
        [Route("update")]
        public HttpResponseMessage UpdateCart(CartItemDTO obj)
        {
            var result = CartService.UpdateCart(obj);
            if (result == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Cart updated successfully");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "update failed");
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public HttpResponseMessage DeleteCart(int id)
        {
            var result = CartService.DeleteCart(id);
            if (result == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Cart deleted successfully");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "delete failed");
        }
        [HttpDelete]
        [Route("delete/item/{id}")]
        public HttpResponseMessage DeleteCartItem(int id)
        {
            var result = CartService.DeleteCartItem(id);
            if (result == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Cart item deleted successfully");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "delete failed");
        }

        [HttpGet]
        [Route("item/all")]
        public HttpResponseMessage GetCartItem()
        {
            var result = CartService.GetCartItem();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("item/{id}")]
        public HttpResponseMessage GetCartItem(int id)
        {
            var result = CartService.GetCartItem(id);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
        [HttpGet]
        [Route("buyer/{buyerId}")]
        public HttpResponseMessage GetCartByUser(int buyerId)
        {
            var result = CartService.GetCartByUser(buyerId);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}