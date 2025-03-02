while (true)
{
    double answer = 0;
    double answer2 = 0;
    double total_answer = 0;
    double total_answer2 = 0;
    double with_stepen = 0;
    double with_stepen_minus = 0;
    double drobn_int = 0;

    Console.WriteLine("Введите число:");
    double user_int = Convert.ToDouble(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Введите систему счисления числа [от 2 до 9]:");
    int number_system = Convert.ToInt32(Console.ReadLine());
    while (number_system < 2 || number_system > 9)
    {
        Console.Clear();
        Console.WriteLine("Недопустимый формат, попробуйте снова");
        Console.WriteLine("Введите систему счисления числа [от 2 до 9]:");
        number_system = Convert.ToInt32(Console.ReadLine());
    }

    //Блок целой части
    string count = user_int.ToString();
    int stepen_plus = 0;
    for (int i = 0; i < count.Length; i++)
    {

        //разделение чисел с конца
        answer = Math.Floor((user_int % Math.Pow(10, (i + 1))) / Math.Pow(10, i));

        //умножение текущего числа на систему счисления, возведённую в степень разрядности 
        with_stepen = answer * Math.Pow(number_system, stepen_plus);

        stepen_plus++;
        total_answer += with_stepen;
    }

    //Блок дробной части
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

    //Блок информации
    Console.Clear();
    Console.WriteLine($"Исходное число: {user_int} \nСистема счисления: {number_system} \n---\nРезультат: {total_answer}");

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