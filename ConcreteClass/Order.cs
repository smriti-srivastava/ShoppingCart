using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.ConcreteClass
{
    class Order: IOrder
    {
        private int _orderId;
        private float _totalAmount;
        private List<IItem> itemList;

        public Boolean createOrder(int id, List<IItem> itemList)
        {
            throw new NotImplementedException();
        }
    }
}
