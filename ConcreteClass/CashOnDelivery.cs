using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.ConcreteClass
{
    class CashOnDelivery : IPayment
    {
        public bool DoPayment(float amount)
        {
            throw new NotImplementedException();
        }
    }
}
