using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.ConcreteClass
{
    class UserOperations : IUserOperations
    {
        private ICart _cart;
        private User _user; 

        public UserOperations(ICart cart, User user)
        {
            this._cart = cart;
            this._user = user;
        }
        public bool AddItemToCard(Item item)
        {
            return this._cart.AddItem(item);
        }

        public bool RemoveItemFromCart(int itemId)
        {
            return this._cart.RemoveItem(itemId);
        }
        public bool ClearCart()
        {
            return this._cart.EmptyCart();
        }

        public Boolean PlaceOrder(IOrder order, IPayment payment)
        {
            throw new NotImplementedException();s
        }
    }
}
