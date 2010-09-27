using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllKindsOfStuff
{
    class NullableTypes
    {
        public void Test() {
            int? dbInt = null;
            while (dbInt == null || dbInt < 10) {
                dbInt = (dbInt ?? 0) + 1;
            }
        }
    }
}
