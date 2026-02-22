using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_2
{
    internal class Cinema
    {
        private Ticket[] _tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index < 0 || index >= _tickets.Length)
                    return null;
                return _tickets[index];
            }
            set
            {
                if (index < 0 || index >= _tickets.Length)
                    return; 
                _tickets[index] = value;
            }
        }
        public Ticket GetMovie(string movieName) 
        {

            foreach (var t in _tickets) 
            { 
              if(t.MovieName==movieName)
                    return t;
            
            }
            return null;
        }

        public bool AddTicket(Ticket ticket) 
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i]==null)
                {
                    _tickets[i] = ticket;
                    return true;
                }
            }
            return false;
        }


    }
}
