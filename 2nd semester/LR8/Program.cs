using LR8;

CargoCompany Gruzi = new();

Gruzi.AddTarrif(new Tariff(1000, new Discount(20), "1000 and 20%"));
Gruzi.AddTarrif(new Tariff(700, new NoDiscount(), "700 and 0%"));
Gruzi.AddTarrif(new Tariff(890, new Discount(10), "890 and 10%"));
Gruzi.AddTarrif(new Tariff(1100, new NoDiscount(), "1100 and 30%"));

Console.WriteLine(Gruzi.FindMinimalTariff());