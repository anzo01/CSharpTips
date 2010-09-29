using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace B_NullableTypes
{
    class Program
    {
        private static void Print(int? value) {
            if (value == null) {
                Debug.Print("Value = NULL");
            } else {
                Debug.Print("Value = " + value);
            }
        }

        static void Main() {

            int? counter = null;
            Print(counter);
            
            counter = 45;
            Print(counter);
            
            counter = null;
            counter += 45; // !!!!!
            Print(counter);

            counter = counter ?? 67;
            Print(counter);
        }
    }
}
