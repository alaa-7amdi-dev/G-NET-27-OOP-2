using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_2
{
    internal struct Seat
    {

        public char SeatRow;
        public int SeatNumber;

        public Seat(char row, int number)
        {
            this.SeatRow = char.ToUpper(row);
            this.SeatNumber = number;
        }
        public override string ToString()
        {
            return $"{SeatRow}{SeatNumber}";
        }
    }
}
