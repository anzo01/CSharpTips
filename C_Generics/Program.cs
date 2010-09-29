using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace C_Generics
{
    class Foo<T> where T : new() {
        public T CreateNew() {
            return new T();
        }

        public Type GetGenericType() {
            return typeof (T);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var x = new Foo<int>().CreateNew();
            Console.Out.WriteLine("x = " + x);

            var s = new Foo<StringBuilder>().GetGenericType();
            Console.Out.WriteLine("s = " + s.FullName);

            var arr = new List<int>(1024);
        }
    }
}
