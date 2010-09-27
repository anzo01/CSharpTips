namespace DataModel {
    public class Customer {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Order[] Orders { get; set; }
    }
}