using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G_PartialClasses
{
    partial class MyClass
    {
        partial void DoIt() {
            Console.Out.WriteLine("DoIt()");
        }
    }
}
