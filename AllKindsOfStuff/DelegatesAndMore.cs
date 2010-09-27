using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllKindsOfStuff
{
    class DelegatesAndMore
    {
        /// <summary>
        /// A mapping of one integer value to another
        /// </summary>
        internal delegate int IntMapping(int x);

        private static int TimesTwo(int x) {
            return x*2;
        }

        public void PerformOnInt(int x, IntMapping mapping) {
            Console.Out.WriteLine("Map result is = " + mapping(x));
        }

        public void PerformOnInt2(int x, Func<int, int> mapping)
        {
            Console.Out.WriteLine("Map result is = " + mapping(x));
        }

        public void Foo()
        {
            PerformOnInt(56, TimesTwo);
            PerformOnInt(12, x => x * 45);
            PerformOnInt2(12, x => x * 45);
        }
    }
}
