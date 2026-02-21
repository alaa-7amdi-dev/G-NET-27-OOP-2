using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_2
{
    internal class StudentRegister
    {
        public string[] names = new string[5];
        public int[] id = new int[5];
        

        public string this[int index]
        {
            get
            {
                Validation(index);
                return names[index];
            }
            set
            {
                Validation(index);
                names[index] = value;
            }

        }
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                    if (names[i] == name)
                        return id[i];
                return 0;
            }
        }

        private void Validation(int index)
            {
                 if (index < 0 || index > names.Length) 
                 { 
                    throw new ArgumentOutOfRangeException("  index Out Of range");
                 }

                 
            }        
        
    }
}
