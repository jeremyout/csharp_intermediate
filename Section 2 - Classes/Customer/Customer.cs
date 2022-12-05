using System.Collections.Generic;
using System.Data;

namespace Customer
{
    public class Customer
    {
        // In the real world, don't use public access modifier
        public int Id;
        public string Name;
        public List<Order> Orders; // Really needs to be initialized

        public Customer() {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this() // Calls the parameterless constructor
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // Calls the constructor with an int input
        {
            this.Name = name;
        }
        // Not considered good practice to pass constructors to other constructors
    }
}
