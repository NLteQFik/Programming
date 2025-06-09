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
            Console.Write("Введите координаты: \nx = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            double dist = x * x + y * y;
            if (dist < 625 && dist > 225)
                Console.WriteLine("Нет");
            else if (dist == 625 || dist == 225)
                Console.WriteLine("На границе");
            else
                Console.WriteLine("Да");
            break;

        default:
            break;
    }

    if (choice)
        break;
}
