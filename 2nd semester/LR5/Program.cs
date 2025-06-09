using LR5;

CargoCompany Gruzoperevozki = new CargoCompany();
Gruzoperevozki.AddTariff("low", 2);
Gruzoperevozki.AddClient("Dima");
Gruzoperevozki.MakeOrder("Kamen", 15);
Gruzoperevozki.MakeOrder("Zhelezo", 30);
Gruzoperevozki.GetOrdersByName("Dima");
Gruzoperevozki.AddTariff("high", 5);
Gruzoperevozki.AddClient("Vlad");
Gruzoperevozki.MakeOrder("Water", Gruzoperevozki.CurrentTariff, 17);
Gruzoperevozki.GetOrdersByName("Vlad");
Console.WriteLine(Gruzoperevozki.GetSum());
Console.WriteLine(Gruzoperevozki.CurrentClient?.GetSum());
Gruzoperevozki.LogOut();
Console.WriteLine(Gruzoperevozki.CurrentClient?.Status);