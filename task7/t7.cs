using static System.Runtime.InteropServices.JavaScript.JSType;

while (true)
{
    double user_int;
    int number_system;
    int number_system2;
    double answer = 0;
    double answer2 = 0;
    double total_answer = 0;
    double with_stepen = 0;
    double with_stepen_minus = 0;
    double drobn_int = 0;
    double number_check = 0;

    while (true)
    {
        Console.Write("Введите число: ");
        if (double.TryParse(Console.ReadLine(), out user_int))
        {
            break;
        }
        else
        {
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
        }
    }
    int count = user_int.ToString().Length;

    while (true)
    {
        Console.Write("Введите систему счисления числа [от 2 до 10]: ");
        if (int.TryParse(Console.ReadLine(), out number_system))
        {
            break;
        }
        else
        {
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
        }
    }

    number_check = user_int;
    while (number_check > 0)
    {
        double for_num = number_check % 10;
        if (for_num >= number_system)
        {
            Console.WriteLine("!Некоторые из чисел в предложенном числе не соответствуют системе счисления");
            while (true)
            {
                Console.Write("Введите систему счисления числа [от 2 до 10]: ");
                if (int.TryParse(Console.ReadLine(), out number_system) && number_system >= 2 && number_system <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("!Недопустимый формат, попробуйте снова");
                }
            }

            number_check = user_int;
        }
        else
        {
            number_check /= 10;
        }
    }

    while (true)
    {
        Console.Write("Введите систему счисления итогового числа [от 2 до 10]: ");
        if (int.TryParse(Console.ReadLine(), out number_system2))
        {
            break;
        }
        else
        {
            Console.WriteLine("!Недопустимый формат, попробуйте снова");
        }
    }

    //Блок целой части (в десятичную)
    int stepen_plus = 0;
    for (int i = 0; i < count; i++)
    {
        answer = Math.Floor((user_int % Math.Pow(10, (i + 1))) / Math.Pow(10, i));

        with_stepen = answer * Math.Pow(number_system, stepen_plus);

        stepen_plus++;
        total_answer += with_stepen;
    }

    //Блок дробной части (в десятичную)
    if (user_int.ToString().Contains(","))
    {
        string[] drobn_int2_str = user_int.ToString().Split(',');
        double drobn_int2 = Convert.ToDouble(drobn_int2_str[1]);
        int stepen_minus = Convert.ToInt32(drobn_int2_str[1].Length) * -1;
        for (int i = 0; i < drobn_int2_str[1].Length; i++)
        {
            answer2 = Math.Floor((drobn_int2 % Math.Pow(10, (i + 1))) / Math.Pow(10, i));
            with_stepen_minus = answer2 * Math.Pow(number_system, stepen_minus);

            stepen_minus++;
            total_answer += with_stepen_minus;
        }
    }

    //если не в десятичную систему
    if (number_system2 >= 2 || number_system2 < 10)
    {
        string Post_Count = total_answer.ToString();
        double user_int_post1 = total_answer;
        string temp_answer_plus = "";
        string temp_answer_minus = "";
        //целая часть
        double tmp1;
        while (user_int_post1 > 0)
        {
            tmp1 = Math.Floor(user_int_post1 % number_system2);
            temp_answer_plus = tmp1.ToString() + temp_answer_plus;
            user_int_post1 = Math.Floor(user_int_post1 / number_system2);
        }
        //дробная часть
        if (total_answer.ToString().Contains(","))
        {
            string[] user_int_post = total_answer.ToString().Split(',');
            double user_int_post2 = Convert.ToDouble("0," + user_int_post[1]);
            for (int i = 0; i < 3; i++)
            {
                string[] user_int_post2_split = (user_int_post2 * number_system2).ToString().Split(",");
                temp_answer_minus += user_int_post2_split[0];
                user_int_post2 = Convert.ToDouble("0," + user_int_post2_split[1]);
            }
            total_answer = Convert.ToDouble($"{temp_answer_plus},{temp_answer_minus}");
        }
        else
        {
            total_answer = Convert.ToDouble(temp_answer_plus);
        }
    }

    //Блок информации
    Console.Clear();
    Console.WriteLine($"Исходное число: {user_int} \nСистема счисления: {number_system} \nПеревод в систему счисления {number_system2}\n---\nРезультат: {total_answer}");

    //Функционал выхода
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