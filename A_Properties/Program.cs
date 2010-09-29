using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace A_Properties
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "Anders Zommarin",
                Address = "Tomtebogatan 30"
            };
            Console.Out.WriteLine("Customer = " + customer.Name);
        }
    }
}
