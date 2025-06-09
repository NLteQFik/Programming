using LR6;

Laptop myLaptop = new Laptop(true, true, "P15HJ", 60, (1920, 1080), "AMD", 16, 8000, 4000);

myLaptop.DisplayInfo();
myLaptop.DisplayStatus();
myLaptop.TurnOff();
myLaptop.UpdateCharge(5000);
myLaptop.DisplayStatus();

Console.WriteLine();

Printer printer = new Printer(false, true, "H84FP", 15, (5760,1440), "Lazer", 5, 120);

printer.DisplayInfo();
printer.DisplayStatus();
printer.TurnOn();
printer.UpdateInkLevel();
printer.DisplayStatus();

Console.WriteLine();

GamingConsole myConsole = new GamingConsole(true, false, "PS4", 40, (1920, 1080), 512);

myConsole.DisplayInfo();
myConsole.DisplayStatus();
myConsole.ChangeStorage(256);
myConsole.DisplayInfo();

Console.WriteLine();

Console.WriteLine(myLaptop.GetCurrentPowerConsumption());
Console.WriteLine(((ComputerEquipment)myLaptop).GetCurrentPowerConsumption());