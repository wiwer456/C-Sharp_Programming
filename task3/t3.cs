string sila = "";
string[] names = {"обезьяна", "петух", "собака", "свинья", "крыса", "бык", "тигр", "кролик", "дракон", "змея", "лошадь", "коза", "некорректные данные"};
int names_id = 0;

Console.WriteLine("Введите ваш год рождения:");
int year = Convert.ToInt32(Console.ReadLine());
int last_int = year % 10;
int year12 = year % 12;

if (year > 0)
{
    if (last_int == 0 || last_int == 1)
    {
        sila = "Металл";
    }
    if (last_int == 2 || last_int == 3)
    {
        sila = "Вода";
    }
    if (last_int == 4 || last_int == 5)
    {
        sila = "Дерево";
    }
    if (last_int == 6 || last_int == 7)
    {
        sila = "Огонь";
    }
    if (last_int == 8 || last_int == 9)
    {
        sila = "Земля";
    }
}
else {
    sila = "некорректные данные";
}

if(year > 0) {
    switch (year12)
    {
        case 0:
            names_id = 0;
            break;
        case 1:
            names_id = 1;
            break;
        case 2:
            names_id = 2;
            break;
        case 3:
            names_id = 3;
            break;
        case 4:
            names_id = 4;
            break;
        case 5:
            names_id = 5;
            break;
        case 6:
            names_id = 6;
            break;
        case 7:
            names_id = 7;
            break;
        case 8:
            names_id = 8;
            break;
        case 9:
            names_id = 9;
            break;
        case 10:
            names_id = 10;
            break;
        case 11:
            names_id = 11;
            break;
        default:
            names_id = 12;
            break;
    }
}
else
{
    names_id = 12;
}


Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Сила: " + sila + ", животное: " + names[names_id]);