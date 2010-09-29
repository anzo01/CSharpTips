using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace F_Using
{
    class Resurs : IDisposable
    {
        static void Main(string[] args)
        {
            using (var stream = new Resurs()) {
                Console.Out.WriteLine("Programmet körs");
            }
        }

        public void Dispose() {
            Console.Out.WriteLine("Nu frigörs mina resurser!!!!");
        }
    }
}
