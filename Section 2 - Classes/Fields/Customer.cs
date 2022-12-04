using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        readonly public List<Order> Orders = new List<Order>(); // can also do this in a default constructor. Be consistent and use the same approach

        public Customer(int id) 
        {
            this.Id= id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name= name;
        }

        public void Promote()
        {
            //Orders = new List<Order>(); // cannot do this on a readonly field
        }
    }
}
