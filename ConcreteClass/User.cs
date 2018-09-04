using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class User
    {
        private int _userId;
        private string _userName;
        public User(int id, string userName)
        {
            this._userId = id;
            this._userName = userName;
        }

    }
}
