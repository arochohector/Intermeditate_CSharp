using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            // lists are needed to be initialized to an empty list, or a nullreferece exception 
            // might occure if you try to add an order without initializing the list first.
            // The default constructor will always initialize the list to an empty list.
            this.Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            // this.Id = id;  Not needed anymore : this() keyword 
            this.Name = name;
        }
    }
}
