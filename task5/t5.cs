while (true)
{
    double y = 0;
    double last_y = 0;
    int function_zeroes = 0;
    int points_count = 0;
    double max_int = double.NegativeInfinity;
    double min_int = double.PositiveInfinity;

    Console.WriteLine("Введите границы отрезка через enter");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите шаг изменения аргумента");
    double h = Convert.ToDouble(Console.ReadLine());
    while (h == 0)
    {
        Console.WriteLine("Некорректные данные");
        h = Convert.ToDouble(Console.ReadLine());
    }

    Console.Clear();
    Console.WriteLine("|----------|-----------|");
    Console.WriteLine("|    x     |      y    |");
    Console.WriteLine("|----------/-----------|");
    for (double x = a; x <= b; x += h)
    {
        y = Math.Round(Math.Cos(x * x) + (Math.Sin(x) * Math.Sin(x)), 2);
        if (y < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        Console.WriteLine($"|      {Math.Round(x, 2)}   |   {Math.Round(y, 2)}   ");
        Console.ResetColor();
        Console.WriteLine("|----------------------|");
        //Console.WriteLine($"При x = ({Math.Round(x, 2)}), y = ({y})");
        if ((y > 0 && last_y < 0) || (y < 0 && last_y > 0) || y == 0)
        {
            function_zeroes++;
        }
        if (y > max_int) { max_int = y; }
        if (y < min_int) { min_int = y; }
        last_y = y;
        points_count++;
    }
    if (points_count > 100)
    {
        Console.WriteLine("|    x     |      y    |");
        Console.WriteLine("|----------------------|");
    }
    Console.ResetColor();
    Console.WriteLine("\n/Сводная Информация:");
    Console.WriteLine($"Количество точек: {points_count}");
    Console.WriteLine($"Нулей функции: {function_zeroes}");
    Console.WriteLine($"Минимальное значение: {min_int}");
    Console.WriteLine($"Максимальное значение: {max_int}");

    Console.WriteLine("\nq - Выйти");
    string uansw = Console.ReadLine();
    if (uansw == "q") { break; }
    else
    {
        Console.Clear();
    }

}
