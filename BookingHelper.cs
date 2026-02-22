using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_2
{
    internal static class BookingHelper
    {
        private static int _counter = 0;
        public static double CalcGroupDiscount(int numOfTickect, double pricePerTicket)
        {
            if (numOfTickect >= 5) 
            {
                return pricePerTicket * numOfTickect * 0.9;
            }
            return pricePerTicket * numOfTickect;
        }
        public static string GenerateBookingReference() 
        {
            _counter++;
            return $"BK + {_counter}";
                 
        }


    }
}
