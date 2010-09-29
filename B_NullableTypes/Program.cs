using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B_NullableTypes
{
    class Program
    {
        private static void Print(int? value) {
            if (value == null) {
                Console.Out.WriteLine("Value = NULL");
            } else {
                Console.Out.WriteLine("Value = " + value);
            }
        }

        static void Main() {

            int? counter = null;
            Print(counter);
            
            counter = 45;
            Print(counter);
            
            counter = null;
            counter += 45;
            Print(counter);

            counter = counter ?? 67;
            Print(counter);
        }
    }
}
