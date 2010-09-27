using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllKindsOfStuff
{
    public struct Coordinate {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class GenericsAndPrimitiveTypes
    {
        public static void main() {
            IList<Coordinate> intList = new List<Coordinate>();

            for (int index = 0; index < 1000; index++) {
                intList.Add(new Coordinate { X = index, Y = index*2 });
            }
        }
    }
}
