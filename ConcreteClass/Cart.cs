using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Cart : ICart
    {
        private List<IItem> _items;
        public Boolean AddItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public Boolean RemoveItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public Boolean EmptyCart()
        {
            throw new NotImplementedException();
        }
    }
}
