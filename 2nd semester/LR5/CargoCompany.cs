using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class CargoCompany
    {
        private List<Tariff> listOfTariffs;
        private List<Client> listOfClients;
        private Client? currentClient;
        private Tariff currentTariff;

        public Client? CurrentClient { get { return currentClient; } }

        public Tariff CurrentTariff { get { return currentTariff; } }

        public CargoCompany()
        {
            listOfTariffs = new List<Tariff>();
            listOfClients = new List<Client>();
            currentClient = null;
            currentTariff = new Tariff();
        }

        public void AddTariff(Tariff tariff)
        {
            currentTariff = tariff;
            listOfTariffs.Add(tariff);
        }

        public void AddTariff(string name, double price)
        {
            currentTariff = new Tariff(name, price);
            listOfTariffs.Add(currentTariff);
        }

        public void AddClient(Client client)
        {
            currentClient = client;
            listOfClients.Add(currentClient);
        }

        public void AddClient(string name)
        {
            currentClient = new Client(name);
            listOfClients.Add(currentClient);
        }

        public void MakeOrder(string name, Tariff tariff, double volume)
        {
            currentClient?.MakeOrder(name, tariff, volume);
        }

        public void MakeOrder(string name, double volume)
        {
            currentClient?.MakeOrder(name, currentTariff, volume);
        }

        public Client? GetClientByName(string name) =>
             listOfClients.Find(x => x.Name == name);
            
        public Tariff? GetTariffByName(string name)
        {
            Tariff? tariff = listOfTariffs.Find(x => x.Name == name);
            return tariff == null
                ? null
                : tariff;
        }

        public void GetOrdersByName(string name)
        {
            Client? client = listOfClients.Find(x => x.Name == name);
            if (client is not null)
            {
                client.GetOrders();
            }
        }

        public double GetSum()
        {
            double sum = 0;
            foreach (Client client in listOfClients)
            {
                sum += client.GetSum();
            }
            return sum;
        }

        public void LogIn(string name)
        {
            currentClient = GetClientByName(name) ?? currentClient;
        }

        public void LogOut()
        {
            currentClient = null;
        }
    }
}
