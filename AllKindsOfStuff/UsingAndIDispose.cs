using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AllKindsOfStuff
{
    class MyResource : IDisposable {
        public void Dispose() {
            Console.Out.WriteLine("CLOSED");
        }
    }

    class UsingAndIDispose
    {
        public void XXX() {
            using (var fw = new StreamWriter("Kalle.txt")) {
                fw.WriteLine("Hej hopp");
            }

            using (var mr = new MyResource()) {
                // ....
            }
        }
    }
}
