bool prm = true;
string zd = "";
int date = 0;
int month = 0;

while (prm == true)
{
    Console.WriteLine("Введите ваше имя:");
    string name = Console.ReadLine();

    Console.WriteLine("Введите вашу фамилию:");
    string surename = Console.ReadLine();

    Console.WriteLine("Введите ваш день рождения:");
    date = Convert.ToInt32(Console.ReadLine());
    bool p1 = true;
    while (p1 == true)
    {
        if (date >= 1 && date <= 31)
        {
            p1 = false;
        }
        else
        {
            Console.WriteLine("!Введите корректное число:");
            date = Convert.ToInt32(Console.ReadLine());
        }
    }


    Console.WriteLine("Введите ваш месяц рождения:");
    month = Convert.ToInt32(Console.ReadLine());
    bool p2 = true;
    while (p2 == true)
    {
        if (month >= 1 && month <= 12)
        {
            if (month == 2 && date >= 29)
            {
                Console.WriteLine("!Введите корректный месяц:");
                month = Convert.ToInt32(Console.ReadLine());
            }
            else { p2 = false; }
        }
        else
        {
            Console.WriteLine("!Введите корректный месяц:");
            month = Convert.ToInt32(Console.ReadLine());
        }
    }

    switch (month)
    {
        case 1:
            if(date >= 1 && date <= 20)
            {
                zd = "Козерог";
            }
            if(date >= 21 && date <= 31)
            {
                zd = "Водолей";
            }
            break;
        case 2:
            if (date >= 1 && date <= 18)
            {
                zd = "Водолей";
            }
            if (date >= 19 && date <= 29)
            {
                zd = "Рыбы";
            }
            break;
        case 3:
            if (date >= 1 && date <= 20)
            {
                zd = "Рыбы";
            }
            if (date >= 21 && date <= 31)
            {
                zd = "Овен";
            }
            break;
        case 4:
            if (date >= 1 && date <= 19)
            {
                zd = "Овен";
            }
            if (date >= 20 && date <= 30)
            {
                zd = "Телец";
            }
            break;
        case 5:
            if (date >= 1 && date <= 20)
            {
                zd = "Телец";
            }
            if (date >= 21 && date <= 31)
            {
                zd = "Близнецы";
            }
            break;
        case 6:
            if (date >= 1 && date <= 21)
            {
                zd = "Близнецы";
            }
            if (date >= 22 && date <= 30)
            {
                zd = "Рак";
            }
            break;
        case 7:
            if (date >= 1 && date <= 22)
            {
                zd = "Рак";
            }
            if (date >= 23 && date <= 31)
            {
                zd = "Лев";
            }
            break;
        case 8:
            if (date >= 1 && date <= 22)
            {
                zd = "Лев";
            }
            if (date >= 23 && date <= 31)
            {
                zd = "Дева";
            }
            break;
        case 9:
            if (date >= 1 && date <= 22)
            {
                zd = "Дева";
            }
            if (date >= 23 && date <= 30)
            {
                zd = "Весы";
            }
            break;
        case 10:
            if (date >= 1 && date <= 23)
            {
                zd = "Весы";
            }
            if (date >= 24 && date <= 31)
            {
                zd = "Скорпион";
            }
            break;
        case 11:
            if (date >= 1 && date <= 22)
            {
                zd = "Скорпион";
            }
            if (date >= 23 && date <= 30)
            {
                zd = "Стрелец";
            }
            break;
        case 12:
            if (date >= 1 && date <= 21)
            {
                zd = "Стрелец";
            }
            if (date >= 22 && date <= 31)
            {
                zd = "Козерог";
            }
            break;
        default: 
            zd = "Не удалось получить результат";
            break;
    }

    

    Console.WriteLine("--------------------------------------");
    Console.WriteLine($"Ваше имя: {name} \nВаша фамилия: {surename} \nВаш знак зодиака: {zd}");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine(" \n1) Попробовать ещё раз \n2) Выйти");
    int tmp = Convert.ToInt32(Console.ReadLine());
    if (tmp == 1)
    {
        Console.Clear();
    }
    else {
        prm = false;
    }
}