while (true)
{
    double a;
    double b;
    double n;
    double itog = 0;


    while (true)
    {
        Console.Write("Введите нижний предел интегрирования: ");
        if (double.TryParse(Console.ReadLine(), out a))
        {
            break;
        }
        else
        {
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
        }
    }

    while (true)
    {
        Console.Write("Введите верхний предел интегрирования: ");
        if (double.TryParse(Console.ReadLine(), out b))
        {
            break;
        }
        else
        {
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
        }
    }

    while (true)
    {
        Console.Write("Введите колличество разбиений треугольника: ");
        if (double.TryParse(Console.ReadLine(), out n))
        {
            break;
        }
        else
        {
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
        }
    }

    double h = (b - a) / n;
    for (int i = 1; i <= n; i++)
    {
        double x = a + i * (h / 2);
        itog += 2 * x * x + 3 * x;
    }
    itog *= h;
    Console.WriteLine($"Ответ: {itog}");






    Console.WriteLine("\nВыйти? \n1) да");
    string u_answ = Console.ReadLine();
    if (u_answ == "1")
    {
        break;
    }
    else
    {
        Console.Clear();
    }
}
