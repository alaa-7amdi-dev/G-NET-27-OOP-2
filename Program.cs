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


        }
    }

}
