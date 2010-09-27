using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using DataModel;

namespace SimpleLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerDb = CustomerDb.Create();

            var q = from customer in customerDb.Customers
                    from order in customer.Orders
                    where order.OrderId == "123"
                    select customer;

            foreach (var customer in q) {
                Console.Out.WriteLine("Customer = " + customer.Name);
            }

            var q2 = from customer in customerDb.Customers
                    from order in customer.Orders
                    where order.OrderId == "999"
                    select new {
                                   CustomerName = customer.Name,
                                   NumberOfOrders = customer.Orders.Count()
                    };
            foreach (var data in q2)
            {
                Console.Out.WriteLine("Customer = " + data.CustomerName + ", count = " + data.NumberOfOrders);
            }

            var serializer = new XmlSerializer(typeof(CustomerDb));
            TextWriter w = new StringWriter();
            serializer.Serialize(w, customerDb);
            Console.Out.WriteLine("XML = " + w);

            Console.Out.WriteLine("Press any key to close");
            Console.In.ReadLine();
        }

    }
}
