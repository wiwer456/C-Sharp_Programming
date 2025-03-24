using System;

while (true)
{
    int size;
    int min_value;
    int max_value;
    Random rnd = new Random();
    int u_answ;

    while (true)
    {
        Console.WriteLine("Действия:\n1) Задать параметры\n2) Выйти");
        if (int.TryParse(Console.ReadLine(), out u_answ))
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

    if (u_answ == 1)
    {
        Console.Clear();
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
                B[i, j] = rnd.Next(min_value, max_value + 1);
            }
        }


        Console.WriteLine("Первая матрица:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nВторая матрица:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }
        while (true)
        {
            Console.ResetColor();
            Console.WriteLine("---\nДействия:\n1)Сложение\n2)Вычитание A-B\n3)Вычитание B-A\n4)Задать новые параметры");
            while (true)
            {
                Console.ResetColor();
                if (int.TryParse(Console.ReadLine(), out u_answ))
                {
                    Console.Clear();
                    Console.WriteLine("Первая матрица:");
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            Console.Write(A[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nВторая матрица:");
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            Console.Write(B[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!Недопустимый формат");
                    Console.ResetColor();
                }
            }

            if (u_answ == 1)
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nСложение матриц:");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {                      
                       Console.Write($"{A[i, j] + B[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }
            else if (u_answ == 2)
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nРазность матриц (A-B):");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{A[i, j] - B[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }
            else if (u_answ == 3)
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nРазность матриц (B-A):");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{B[i, j] - A[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }
            else if (u_answ == 4)
            {
                Console.Clear();
                break;
            }
            else 
            { 
                continue; 
            }
        }
    }
    else
    {
        break;
    }
}