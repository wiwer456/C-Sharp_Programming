Random rnd = new Random();
double[] zp = new double[12];
double zp_all = 0;
double zp_pen = 0;
double zp_max = double.MinValue;
double zp_max_num = 0;
double zp_min = double.MaxValue;
double zp_min_num = 0;
double razn = 0;

for (int i = 0; i < zp.Length; i++)
{
    zp[i] = rnd.Next(1000, 5001);
    zp_all += zp[i];
}

Console.WriteLine("Зарплата по месяцам:");

for (int i = 0;i < zp.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"за {i+1} месяц - {zp[i]}$");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write($" (отчисление в фонд: {Math.Round(zp[i] * 0.02, 2)}$)");

    razn = Math.Round(Math.Abs((zp_all / 12) - zp[i]), 2);
    if (zp_all / 12 > zp[i]) { Console.ForegroundColor= ConsoleColor.Red; }
    else if (zp_all / 12 < zp[i]) { Console.ForegroundColor = ConsoleColor.Green; }
    Console.WriteLine($" | отклонение от средней з.п. - {razn}");

    zp_pen += zp[i] * 0.02;
    if (zp[i] > zp_max) {
        zp_max = zp[i];
        zp_max_num = i + 1;
    }
    if (zp[i] < zp_min) { 
        zp_min = zp[i];
        zp_min_num = i + 1;
    }
}
Console.ResetColor();

Console.WriteLine("\n---------------------------------------------------------------");
Console.WriteLine($"общая сумма зарплаты за год: {zp_all}$");
Console.WriteLine($"Средняя сумма зарплаты за год: {Math.Round(zp_all / 12, 2)}$");
Console.WriteLine($"Общее отчисление в пенсионный фонд за год: {Math.Round(zp_pen, 2)}$");
Console.WriteLine($"Максимальная зарплата: {zp_max}$ (за {zp_max_num} месяц)");
Console.WriteLine($"Минимальная зарплата: {zp_min}$ (за {zp_min_num} месяц)");