using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_2
{
    internal class Ticket
    {
        private string _movieName=string.Empty;
        private TicketType _type;
        private Seat _seat { get; set; }
        private double _price { get; set; }
        public static int TicketCounter = 0;
        
        public int TicketId { get; private set; }


        const double tax = 0.14;



        //public Ticket(string movieName)
        //{
        //    _movieName = movieName;
        //    TicketCounter++;
        //    TicketId = TicketCounter;

        //}
        public Ticket(string movieName,TicketType type , Seat seat,double price)
        {
            _movieName = movieName;
            _type = type;
            _seat = seat;
            _price = price;
            TicketCounter++;
            TicketId = TicketCounter;

        }

        public static int GetTotalTicketsSold() 
        {
            return TicketCounter;
        }



        public string MovieName
        {
            get 
            {
                return _movieName;
            }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    _movieName = value;
            }
        
        }

        public TicketType Type 
        {
            get 
            {
                return _type;
            }
            set 
            { 
                _type = value;
            }
        
        }
        public Seat seat 
        {
            get 
            {
                return _seat;
            }
            set 
            { 
                _seat = value;
            }
        
        }

        public double Price
        {


            get
            {
                return _price;
            }

            set
            { 
               if(value > 0)
                  _price=value;

            }
        }
        public double PriceAfterTax
        {
            get
            {
                return _price + ( _price * tax );
            }
        
        }
    }
}
