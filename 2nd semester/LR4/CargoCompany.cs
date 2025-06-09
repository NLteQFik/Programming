using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class CargoCompany
    {
        private static CargoCompany ?instance;
        private Tariff currentTariff;
        private string companyName;
        private double mass;

        public double CurrentTariffPrice
        {
            get { return currentTariff.Price; }
            set { currentTariff.Price = value; }
        }

        public string CompanyName
        { 
            get { return companyName; }
            set { companyName = value; }
        }

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        private CargoCompany()
        { 
            currentTariff = new Tariff();
            companyName = string.Empty;
            mass = 0;
        }

        public static CargoCompany GetInstance()
        {
            return instance ?? new CargoCompany();
        }

        public void changeTariff(double amount)
        {
            currentTariff.changeTariff(amount);
        }

        public double calculateProfit()
        {
            return currentTariff.Price * mass;
        }
    }
}
