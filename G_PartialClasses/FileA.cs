using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G_PartialClasses
{
    partial class MyClass
    {
        partial void DoIt();
        partial void DontDoIt();

        public static void Main() {
            var myClass = new MyClass();

            myClass.DoIt();
            myClass.DontDoIt();
        }
    }
}
