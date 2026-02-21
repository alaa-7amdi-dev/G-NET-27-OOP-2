using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_2
{
    internal class BankAccount
    {
        private string _owner=default!;
        private double _balance;

        public void Withdrow(double balane)
        {
            if (balane < 0) 
            
               throw new ArgumentOutOfRangeException(nameof(balane));
              
            
            _balance = balane;
        }

    }
}
