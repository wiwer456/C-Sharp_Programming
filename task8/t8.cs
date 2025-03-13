while (true)
{
    double x0;
    double y0;
    double v0;
    double a;
    double a_radian;
    double x = 0;
    double y = 0;
    double t = 0;
    double g = 9.81;
    double y_max = 0;

    while (true)
    {
        Console.WriteLine("Введите координаты пушкии 'x y' с новой строчки: ");
        if (double.TryParse(Console.ReadLine(), out x0) && double.TryParse(Console.ReadLine(), out y0))
        {
            if (y0 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Координата высоты должна быть положительной");
                Console.ResetColor();
                continue;
            }
            else
            {
                break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
            Console.ResetColor();
        }
    }

    while (true)
    {
        Console.Write("Введите начальную скорость снаряда (м/c): ");
        if (double.TryParse(Console.ReadLine(), out v0))
        {
            if (v0 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!Значение скорости должно быть положительным");
                Console.ResetColor();
                continue;
            }
            else
            {
                break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
            Console.ResetColor();
        }
    }

    while (true)
    {
        Console.Write("Введите угол вылета снаряда: ");
        if (double.TryParse(Console.ReadLine(), out a) && a <= 360)
        {
            if (a < 0) 
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!Значение угла должно быть положительным");
                Console.ResetColor();
                continue;
            }
            if (y0 == 0)
            {
                if (a > 180)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!Максимальное значение угла для введённых координат - '180'");
                    Console.ResetColor();
                    continue;
                }
            }
            a_radian = a * (Math.PI / 180);
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
            Console.ResetColor();
        }
    }

    
    Console.WriteLine("|------------|-----------|");
    Console.WriteLine("|      x     |      y    |");
    Console.WriteLine("|------------/-----------|");
    while (y >= 0)
    {

        x = x0 + (v0 * Math.Cos(a_radian)) * t;
        y = y0 + (v0 * Math.Sin(a_radian)) * t - ((g * t * t) / 2);
        if (y < 0)
        {
            break;
        }
        if (y_max < y) 
        {
            y_max = y;
        }
        Console.WriteLine($"|    {Math.Round(x, 2)}   |   {Math.Round(y, 2)}   ");
        t += 0.1;
    }
    

    //Console.WriteLine("---\nДополнительные сведения:");
    //string con = "";
    //if (Math.Round(y_max) % 10 == 0 || Math.Round(y_max) % 10 >= 5 && Math.Round(y_max) % 10 <= 9) { con = "ов"; }
    //if (Math.Round(y_max) % 10 >= 2 && Math.Round(y_max) % 10 <= 4) { con = "а"; }
    //Console.WriteLine($"Максимальная высота снаряда: ~{Math.Round(y_max, 2)} метр{con}");


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