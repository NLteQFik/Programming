while (true)
{
    Console.Write("Введите Продолжить или Закончить: ");
    string s = Console.ReadLine();
    bool choice = false;

    switch (s)
    {
        case "Закончить":
            choice = true;
            break;

        case "Продолжить":
            Console.Write("Введите двузначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a / 10 == a % 10)
                Console.WriteLine("Цифры одинаковы.");
            else
                Console.WriteLine("Цифры различны.");
            break;

        default:
            break;
    }

    if (choice)
        break;
}
