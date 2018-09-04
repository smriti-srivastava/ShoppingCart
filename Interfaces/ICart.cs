using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    interface ICart
    {
        Boolean AddItem(IItem item);
        bool RemoveItem(int itemId);
        Boolean EmptyCart();
      
    }
}
