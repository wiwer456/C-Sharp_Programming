```C#
Random rnd = new Random();
int rndInt = rnd.Next(1, 101);
int trys_count = 5;
int guess = 0;

Console.WriteLine("Угадайте число от 1 до 100");
//Console.WriteLine(rndInt);
switch (trys_count)
{
    case 1:
        Console.WriteLine("Введите ваше предположение:");
        guess = Convert.ToInt32(Console.ReadLine());
        while (guess < 1 || guess > 100)
        {
            Console.Clear();
            Console.WriteLine("Некорректный ввод. Введите число от 1 до 100:");
            guess = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        if (guess != rndInt)
        {
            goto default;
        }
        else if (guess == rndInt)
        {
            Console.WriteLine("Правильно :)");
            break;
        }
        else
        {
            goto default;
        }
    case 2:
        Console.WriteLine("Введите ваше предположение:");
        guess = Convert.ToInt32(Console.ReadLine());
        while (guess < 1 || guess > 100)
        {
            Console.Clear();
            Console.WriteLine("Некорректный ввод. Введите число от 1 до 100:");
            guess = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        if (guess != rndInt)
        {
            trys_count--;
            Console.WriteLine($"Неправильно. Осталось попыток: {trys_count}");
            Console.WriteLine("-----------------------------------");
            goto case 1;
        }
        else if (guess == rndInt)
        {
            Console.WriteLine("Правильно :0");
            break;
        }
        else
        {
            goto default;
        }
    case 3:
        Console.WriteLine("Введите ваше предположение:");
        guess = Convert.ToInt32(Console.ReadLine());
        while (guess < 1 || guess > 100)
        {
            Console.Clear();
            Console.WriteLine("Некорректный ввод. Введите число от 1 до 100:");
            guess = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        if (guess != rndInt)
        {
            trys_count--;
            Console.WriteLine($"Неправильно. Осталось попыток: {trys_count}");
            Console.WriteLine("-----------------------------------");
            goto case 2;
        }
        else if (guess == rndInt)
        {
            Console.WriteLine("Правильно :D");
            break;
        }
        else
        {
            goto default;
        }
    case 4:
        Console.WriteLine("Введите ваше предположение:");
        guess = Convert.ToInt32(Console.ReadLine());
        while (guess < 1 || guess > 100)
        {
            Console.Clear();
            Console.WriteLine("Некорректный ввод. Введите число от 1 до 100:");
            guess = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        if (guess != rndInt)
        {
            trys_count--;
            Console.WriteLine($"Неправильно. Осталось попыток: {trys_count}");
            Console.WriteLine("-----------------------------------");
            goto case 3;
        }
        else if (guess == rndInt)
        {
            Console.WriteLine("Правильно :3");
            break;
        }
        else
        {
            goto default;
        }
    case 5:
        Console.WriteLine("Введите ваше предположение:");
        guess = Convert.ToInt32(Console.ReadLine());
        while(guess < 1 || guess > 100)
        {
            Console.Clear();
            Console.WriteLine("Некорректный ввод. Введите число от 1 до 100:");
            guess = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        if (guess != rndInt)
        {
            trys_count--;
            Console.WriteLine($"Неправильно. Осталось попыток: {trys_count}");
            Console.WriteLine("-----------------------------------");
            goto case 4;
        }
        else if (guess == rndInt)
        {
            Console.WriteLine("Правильно ;)");
            break;
        }
        else
        {
            goto default;
        }
    default:
        Console.WriteLine($"У тебя закончились попытки :( \nОтвет был: {rndInt}");
        break;
}
```
