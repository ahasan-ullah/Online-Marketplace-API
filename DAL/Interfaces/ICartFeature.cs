using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICartFeature
    {
        bool UpdateCartItem(CartItem obj);
        CartItem GetCartItem(int id);
        bool DeleteCartItem(int id);
    }
}
