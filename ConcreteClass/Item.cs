using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Item: IItem
    {
        private int _itemId;
        private string _itemName;
        private int _quantity;
        private decimal _price;

        public void CreateItem()
        {
            throw new NotImplementedException();
        }
    }
}
