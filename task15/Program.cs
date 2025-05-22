
class Program()
{
    static void Main()
    {
        int cars_count = IntChecker("Введите размер автопарка: "); ;
        while (cars_count < 1)
        {
            Print("Введите число от 1");
            cars_count = IntChecker("Введите размер автопарка: ");
        }
        Random rnd = new Random();

        Avt[] cars = new Avt[cars_count];
        int id = 0;
        int u_id = 0;
        Console.Clear();
        while (true)
        {
            int u_answer = IntChecker("Меню:\n1) Добавить машину\n" +
                "2) Выбрать машину\n" +
                "3) Ехать на машине\n" +
                "4) Заправить машину\n" +
                "5) Вывести информацию о машинах\n" +
                "6) Авария\n");
            while (u_answer > 6 || u_answer < 1) 
            {
                Print("Введите число от 1 до 6");
                u_answer = IntChecker("Меню:\n1) Добавить машину\n" +
                "2) Выбрать машину\n" +
                "3) Ехать на машине\n" +
                "4) Заправить машину\n" +
                "5) Вывести информацию о машинах\n" +
                "6) Авария\n");
            }
            switch (u_answer)
            {
                case 1:
                    Console.Clear();
                    if (id > cars.Length-1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("!Достигнут максимум по кол-ву машин");
                        Console.ResetColor();
                        break;
                    }
                    
                    Console.Write("Введеите номер машины: ");
                    string name = Console.ReadLine();
                    Console.Write("Введеите марку машины: ");
                    string marka = Console.ReadLine();
                    double max_fuel = doubleChecker("Объём бака: "); ;
                    while (max_fuel <= 0)
                    {
                        Print("Введите число больше 0");
                        max_fuel = doubleChecker("Объём бака: ");
                    }
                    double bak = doubleChecker("Начальное кол-во бензина: "); ;
                    while (bak > max_fuel || bak <= 0)
                    {
                        Print($"Введите число от 0 до {max_fuel}");
                        bak = doubleChecker("Начальное кол-во бензина: ");
                    }
                    double ras = doubleChecker("Расход бензина на 100км: "); ;
                    while (ras <= 0)
                    {
                        Print("Введите число больше 0");
                        ras = doubleChecker("Расход бензина на 100км: ");
                    }
                    Console.Clear();
                    Avt car = new Avt();
                    car.Info(name, marka, bak, max_fuel, ras);
                    cars[id] = car;
                    id++;
                    break;
                case 2:
                    Console.Clear();
                    if (id < 1) { goto case 7; }
                    u_id = IntChecker("Введите id машины: ");
                    while(u_id < 0 || u_id >= cars_count)
                    {
                        Print("Машина с таким id не существует");
                        u_id = IntChecker("Введите id машины: ");
                    }
                    break;
                case 3:
                    if (cars[u_id] != null)
                    {
                        int x = IntChecker("Введите новую координату x: ");
                        int y = IntChecker("Введите новую координату y: ");
                        Console.Clear();
                        cars[u_id].Move(x, y);
                        break;
                    }
                    goto case 7;
                case 4:
                    Console.Clear();
                    if (cars[u_id] != null && cars[0] != null)
                    {
                        double tmp_fu = doubleChecker("Кол-во топлива: ");
                        while (tmp_fu <= 0)
                        {
                            Print("Введите число больше 0");
                            tmp_fu = doubleChecker("Кол-во топлива: ");
                        }
                        cars[u_id].Zaprafka(tmp_fu);
                        break;
                    }
                    goto case 7;
                case 5:
                    if (cars[0] != null)
                    {
                        int u_ans = IntChecker("1) Вывести информацию о выбранной машине\n" +
                            "2) Вывести информацию о всех машинах\n");
                        while (u_ans < 1 || u_ans > 2)
                        {
                            Print("Введите число от 1 до 2");
                            u_ans = IntChecker("1) Вывести информацию о выбранной машине\n" +
                            "2) Вывести информацию о всех машинах\n");
                        }
                        Console.Clear();
                        Console.WriteLine("Информация:\n");
                        switch (u_ans)
                        {
                            case 1:
                                cars[u_id].Out();
                                break;
                            case 2:
                                foreach (Avt av in cars)
                                {
                                    if (av != null) { av.Out(); }
                                }
                                break;
                        }
                        break;
                    }
                    goto case 7;
                case 6:
                    Console.Clear();
                    if (cars[0] != null)
                    {
                        int car_c = rnd.Next(0, cars_count);
                        if (car_c != u_id && cars[car_c] != null)
                        {
                            cars[u_id].Avaria(cars[car_c]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Машина врезалась в забор");
                            break;
                        }
                    }
                    goto case 7;
                case 7:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("!Заполните информацию о машинах");
                    Console.ResetColor();
                    break;

            }
        }
    }
    static double doubleChecker(string text)
    {
        while (true)
        {
            Console.Write(text);
            if (double.TryParse(Console.ReadLine(), out double u_answer))
            {
                return u_answer;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!Неверный формат");
                Console.ResetColor();
            }
        }
    }
    static int IntChecker(string text)
    {
        while (true)
        {
            Console.Write(text);
            if (int.TryParse(Console.ReadLine(), out int u_answer))
            {
                return u_answer;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!Неверный формат");
                Console.ResetColor();
            }
        }
    }
    static void Print(string str)
    {
        Console.Clear();
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine(str);
        Console.ResetColor();
    }
}
