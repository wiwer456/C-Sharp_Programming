class Program
{
    static void Main()
    {
        int x = 0;
        int y = 0;
        int sn_int = 1;
        int u_answer;
        while (true)
        {
            Console.Write("Введите размер квадрата: ");
            if (int.TryParse(Console.ReadLine(), out u_answer))
            {
                if (u_answer > 100 || u_answer < 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!Введите число от 2 до 100");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!Введите число от 2 до 100");
                Console.ResetColor();
            }
        }

        int[,] sn = new int[u_answer, u_answer];
        for (int i = 0; i < sn.GetLength(0); i++)
        {
            for (int j = 0; j < sn.GetLength(1); j++)
            {
                sn[i, j] = 0;
            }
        }


        //первое значение
        sn[y, x] = sn_int;
        sn_int++;
        while (x + 1 < u_answer)

        //первая половина
        {
            if (y + 1 < u_answer)
            {
                y++;
                sn[y, x] = sn_int;
                sn_int++;
            }
            //если нечётное кол-во клеток грани квадрата
            else
            {
                x++;
                sn[y, x] = sn_int;
                sn_int++;
                break;
            }

            while (x + 1 < u_answer && y - 1 >= 0)
            {
                x++;
                y--;
                sn[y, x] = sn_int;
                sn_int++;
            }
            if (x + 1 >= u_answer) { break; }
            x++;
            sn[y, x] = sn_int;
            sn_int++;
            while (x - 1 >= 0 && y + 1 < u_answer)
            {
                x--;
                y++;
                sn[y, x] = sn_int;
                sn_int++;
            }
        }

        //вторая половина
        while (sn_int < u_answer * u_answer)
        {
            if (sn.GetLength(0) % 2 == 1)
            {
                while (x + 1 < u_answer && y - 1 >= 0)
                {
                    x++;
                    y--;
                    sn[y, x] = sn_int;
                    sn_int++;
                }
                if (sn.GetLength(0) == 3)
                {
                    break;
                }
            }
            y++;
            sn[y, x] = sn_int;
            sn_int++;

            while (y + 1 < u_answer)
            {
                y++;
                x--;
                sn[y, x] = sn_int;
                sn_int++;
            }
            x++;
            sn[y, x] = sn_int;
            sn_int++;
            while (x + 1 < u_answer)
            {
                y--;
                x++;
                sn[y, x] = sn_int;
                sn_int++;
            }
        }

        //последнее значение
        y++;
        sn[y, x] = sn_int;
        sn_int++;

        print();
        //вывод
        void print()
        {
            Console.Clear();
            Console.WriteLine($"Змейка для квадрата со стороной {u_answer}:\n");
            for (int i = 0; i < u_answer; i++)
            {
                for (int j = 0; j < u_answer; j++)
                {
                    Console.Write(sn[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}