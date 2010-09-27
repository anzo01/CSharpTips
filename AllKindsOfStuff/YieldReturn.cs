using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllKindsOfStuff
{
    class YieldReturn
    {
        public IEnumerable<int> AllIntegers() {
            var counter = 0;
            while (true) {
                yield return counter++;
            }
        }
    }
}
