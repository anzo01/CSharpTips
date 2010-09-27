namespace DataModel {
    public class CustomerDb {
        /// <summary>
        /// The list of customers known
        /// </summary>
        public Customer[] Customers { get; set; }

        /// <summary>
        /// Create an example data structure
        /// </summary>
        /// <returns></returns>
        public static CustomerDb Create() {
            return new CustomerDb {
                Customers = new[] {
                    new Customer { 
                        Name = "Kalle Jönsson", 
                        Address = "Rotvägen 10", 
                        Orders = new[] {
                            new Order { OrderId = "123" }, new Order { OrderId = "192" }
                        }
                    },
                    new Customer { 
                        Name = "Olle Nilsson", 
                        Address = "liljavägen 45", 
                        Orders = new[] {
                            new Order { OrderId = "981" }, new Order { OrderId = "12" }, new Order { OrderId = "999" }
                        }
                    }
                }
            };
        }
    }
}