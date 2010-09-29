using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D_Complex
{
    class Complex
    {
        public double Re { get; set; }

        public double Im { get; set; }
        
        public Complex(double re, double im) {
            Re = re;
            Im = im;
        }
        
        public static Complex operator + (Complex x, Complex that) {
            return new Complex(x.Re + that.Re, x.Im + that.Im);
        }

        public override string ToString()
        {
            return "(" + Re + " + " + Im + "i)";
        }
        
        static void Main(string[] args)
        {
            var a = new Complex(3, 4);
            var b = new Complex(10, 20);
            var c = a + b;
            Console.Out.WriteLine("Result = " + c);
        }
    }
}
