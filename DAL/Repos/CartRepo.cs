using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CartRepo : IRepo<Cart, int, bool>, ICartFeature
    {
        MarketContext db;
        public CartRepo()
        {
            db=new MarketContext();
        }
        public bool Create(Cart obj)
        {
            db.Carts.Add(obj);
            return db.SaveChanges() > 0;
        }


        //cart delete
        public bool Delete(int id)
        {
            var cart = db.Carts.Find(id);
            if (cart == null) return false;

            db.Carts.Remove(cart);
            return db.SaveChanges() > 0;
        }

        public List<Cart> Get()
        {
            return db.Carts.ToList();
        }

        public Cart Get(int id)
        {
            return db.Carts.Find(id);
        }



        //cartitem remove func should be added

        //this is for cart repo update
        public bool Update(Cart obj)
        {
            throw new NotImplementedException();
        }


        //cart item repo


        public CartItem GetCartItem(int id)
        {
            var cartItem=db.CartItems.Find(id);
            return cartItem;
        }

        public bool UpdateCartItem(CartItem obj)
        {
            var extCartItem = GetCartItem(obj.Id);
            if (extCartItem != null)
            {
                extCartItem.Quantity = obj.Quantity;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool DeleteCartItem(int id)
        {
            var cartItem = GetCartItem(id);
            db.CartItems.Remove(cartItem);
            return db.SaveChanges() > 0;
        }

        public List<CartItem> GetAllCartItems()
        {
            return db.CartItems.ToList();
        }

        public List<Cart> getCartByUser(int id)
        {
            var carts = (from c in db.Carts where c.BuyerId == id select c).ToList();
            return carts;
        }
    }
}
