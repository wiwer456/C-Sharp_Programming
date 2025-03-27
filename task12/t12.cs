while (true)
{
    int size;
    int min_value;
    int max_value;
    Random rnd = new Random();
    int count = 0;
    int u_ans;

    while (true)
    {
        Console.Write("Введите размерность матриц:");
        if (int.TryParse(Console.ReadLine(), out size))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!Недопустимый формат");
            Console.ResetColor();
        }
    }

    while (true)
    {
        Console.WriteLine("Диапазон случайных чисел c новой строки:");
        if (int.TryParse(Console.ReadLine(), out min_value) && int.TryParse(Console.ReadLine(), out max_value))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!Недопустимый формат");
            Console.ResetColor();
        }
    }

    int[,] A = new int[size, size];
    int[,] B = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            A[i, j] = rnd.Next(min_value, max_value + 1);
        }
    }

    Console.WriteLine("\nИзначальная матрица:");
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(A[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Треугольная матрица:");
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            B[i, j] = A[i, j];
            if (j > count)
            {
                B[i, j] = 0;
            }
            Console.Write(B[i, j] + "\t");
        }
        count++;
        Console.WriteLine();
    }

    int rows = B.GetLength(0);
    int lines = B.GetLength(1);
    Console.WriteLine("Отзеркаленная матрица:");
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(B[rows - i - 1, lines - j - 1] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Выйти?\n1) да");
    u_ans = Convert.ToInt32(Console.ReadLine());
    if (u_ans == 1)
    {
        break;
    }
    else
    {
        Console.Clear();
    }
}