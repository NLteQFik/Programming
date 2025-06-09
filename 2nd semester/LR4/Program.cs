// See https://aka.ms/new-console-template for more information
using LR4;

CargoCompany ex = CargoCompany.GetInstance();

Console.WriteLine("Profit of company {0} is {1} with mass {2} and tariff {3}", ex.CompanyName, ex.calculateProfit(), ex.Mass, ex.CurrentTariffPrice);

ex.CompanyName = "Gruzoperevozki";
ex.Mass = 58.23;
ex.CurrentTariffPrice = 101.3;

Console.WriteLine("Profit of company {0} is {1} with mass {2} and tariff {3}", ex.CompanyName, ex.calculateProfit(), ex.Mass, ex.CurrentTariffPrice);

ex.changeTariff(12.3);

Console.WriteLine("Profit of company {0} is {1} with mass {2} and tariff {3}", ex.CompanyName, ex.calculateProfit(), ex.Mass, ex.CurrentTariffPrice);
