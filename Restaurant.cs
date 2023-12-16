using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Restaurant
    {
        private List<Customer> _customers = new();
        private List<MenuItem> _menu = new();

        public void AddCustomer(Customer customer)
        { 
            _customers.Add(customer);
        }

        public MenuItem GetMenuItem(int index)
        { 
            if (index >= 0 && index < this._menu.Count) 
            {
                return this._menu[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
           
        }
        public void AddMenuItem(MenuItem item) 
        {
            _menu.Add(item);
        }
        public void PlaceOrder(Customer customer, Order order) 
        {
            customer.AddOrder(order);
        }
        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items:");
            foreach (MenuItem item in _menu)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void DisplayOrderHistory(Customer customer)
        {
            Console.WriteLine($"{customer.Name}'s Order History:");
            foreach (Order order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Total: ${order.GetTotal()}");
                
                foreach (MenuItem item in order.Items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
