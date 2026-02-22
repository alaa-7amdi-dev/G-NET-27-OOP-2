using System.Reflection.Metadata;

namespace G_NET_27_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //A:
            //1=> Field must be private.
            //2=>There needs to be a validation before modification.
            //C:
            // When you expose a field as public=> anyone can access the field (read && write) no validation 
            //that conflicts with encapsulation principle.
            #endregion
            #region Q2
            // field=>(a):direct access (no validation)
            //(b):Breaks encapsulation
            //property
            //(a):Controlled access
            //(b):With validation
            //(c):Enforces encapsulation

            ///////////////////////////////

            //B=> Yes :A property is essentially a pair of methods (get/set) to access field.

            /////////////////////////////

            //(C)=>
            /*
             privat double _width;
             privat double _height;

            public double Widht {get; set;}
            public double Height {get; set;}
              
               public double Area 
                  {
                      get
                      { 
                        return _width * _height;
                      }
                  }
             */
            #endregion

            #region Q3
            //A:
            //An indexer=> that lets an object be accessed like an array using [] syntax.

            //B:

            // will throw exception ArgementOutOfRange of an array , should validation 
            // before adding;

            //  StudentRegister student = new StudentRegister();
            //student[10] = "alaa";


            //C : yes , but when the signatures is diffrence in( number of parameters , type ... , order ..)
            //example in StudentRegister class.
            #endregion

            #region Q4
            // The static keyword means that a member belongs to the type itself not to a specific object instance and shared in the class which it belongs.
            // field item is a puplic member belongs to a specific object instance.

            ////////
            //(B):
            /// No , the static member belongs to a class itself, no to any object, therefore cannot access instance member directly.
            #endregion

            #region Part 02
            Cinema cinema = new Cinema();
            Console.WriteLine("#######TicketBooking#######");
            for (int i = 0; i < 3; i++) 
            {
                
                Console.WriteLine($"Enter data for Ticket {i+1} :");
                Console.Write("Movie Name :");
                string? movieName = Console.ReadLine();
                Console.Write("Ticket Type (0=Standar 1=Vip 2=IMAX) :");
                TicketType ticketType = (TicketType)int.Parse(Console.ReadLine());
                Console.Write("Seat Row (A=>z) :");
                char row = char.Parse(Console.ReadLine());
                Console.Write("Seat Number :");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Price : ");
                double price = double.Parse(Console.ReadLine());

                Seat seat = new Seat(row, number);
                Ticket ticket = new Ticket(movieName, ticketType, seat, price);

                cinema.AddTicket(ticket);
            }

            for (int i = 0; i < 3; i++)
            {
                Ticket t = cinema[i];
                Console.WriteLine($"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | " +
                                  $"Seat: {t.seat} | Price: {t.Price} EGP | " +
                                  $"After Tax: {t.PriceAfterTax} EGP");
            }



            Console.Write("Enter Movie Name");
            string Monvie = Console.ReadLine();

            Ticket search = cinema.GetMovie(Monvie);
            if (search != null)
            {
                Console.WriteLine($"{search.MovieName} | {search.Type} | {search.seat} | {search.Price}");
            }
            else 
            {
                Console.WriteLine("No Found");
            }

            Console.WriteLine($"Total Tickets Soild = {Ticket.GetTotalTicketsSold()}");

            
            Console.WriteLine($"Booking Reference 1 : {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Reference 2 : {BookingHelper.GenerateBookingReference()}");

            
            Console.WriteLine($" Group Discount (5 tickets x 80 EGP): {BookingHelper.CalcGroupDiscount(5, 80)} EGP (10% off applied)");


            #endregion

        }
    }

}
