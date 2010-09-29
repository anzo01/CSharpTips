using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllKindsOfStuff
{
    class Base
    {
        public virtual void Foo() {
            // Something
        }
        public void Fie() {
            
        }
    }

    class Derived : Base {
        public override void Foo()
        {
            // Something else
        }

        public new void Fie() {
            
        }
    }
}
