using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    enum ClientStatus
    {
        Ordinary = 0,
        VIP = 1
    }
    internal partial class Client
    {
        private List<Order> listOfOrders = new List<Order>();

        public ClientStatus Status { get; set; }

        public string Name { get; set; }

        public Client()
        { 
            Name = string.Empty;
        }

        public Client(string name)
        {
            Name = name;
        }

        public void GetOrders()
        {
            foreach (var order in listOfOrders)
            {
                Console.WriteLine($"Name: {order.Name}, Price: {order.GetPrice()}");
            }
        }

        public void MakeOrder(string name, Tariff tariff, double volume)
        {
            listOfOrders.Add(new Order(name, tariff, volume));
        }

        public double GetSum()
        {
            double sum = 0;
            foreach (var order in listOfOrders)
            {
                sum += order.GetPrice();
            }
            return sum;
        }
    }
}
