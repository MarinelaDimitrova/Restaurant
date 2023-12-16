using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        private List<Order> _orderHistory = new();

        public string Name { get; set; }
        public string Email { get; set; }
        public IReadOnlyCollection<Order> OrderHistory => this._orderHistory.AsReadOnly(); 

        public Customer(string name, string email) 
        {
            this.Name = name;
            this.Email = email;
        }

        public void AddOrder(Order order)
        {
            _orderHistory.Add(order);
        }
    }
}
