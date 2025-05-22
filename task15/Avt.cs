using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Avt
{
    private string Avto_number;
    private string Avto_marka;
    private double Fuel_value; // кол-во в баке
    private double Fuel_rate; // расход
    private double Probeg;
    private double Max_fuel_value;
    private int Pos_x = 0;
    private int Pos_y = 0;
    private int Speed;
    public void Info(string nom, string marka, double bak, double max_bak, double ras)
    {
        Avto_number = nom;
        Avto_marka = marka;
        Fuel_value = bak;
        Max_fuel_value = max_bak;
        Fuel_rate = ras;
        Probeg = 0;
    }
    public void Out()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"| Номер авто: {Avto_number}\n" +
                 $"| Марка авто: {Avto_marka}\n" +
                 $"| Кол-во бензина: {Fuel_value:F2} л\n" +  
                 $"| Расход бензина: {Fuel_rate:F2} л/100км\n" +
                 $"| Пробег: {Probeg:F2} км\n" +
                 $"| Позиция: ({Pos_x}; {Pos_y})\n");
        Console.ResetColor();
    }
    public void Zaprafka(double top)
    {
        if (Fuel_value + top <= Max_fuel_value)
        {
            Fuel_value += top;
            Ostatok();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!Слишком большое кол-во бензина, бак залит до максимума");
            Console.ResetColor();
            Fuel_value = Max_fuel_value;
        }
    }
    public void Move(int x, int y)
    {
        double km = Math.Sqrt(Math.Pow(x - Pos_x, 2) + Math.Pow(y - Pos_y, 2));
        Console.WriteLine($"Нужно проехать {km:F2} км");
        Razgon();
        Console.WriteLine($"Машина едет со скоростью {Speed} км/ч");
        double tmp_km = km;
        while (km != 0)
        {
            if ((Fuel_value / Fuel_rate) * 100 >= km)
            {
                Fuel_value -= (km / 100) * Fuel_rate;
                km = 0;
                Probeg += tmp_km;
                Pos_x = x;
                Pos_y = y;
                Stop();
                Ostatok();
            }
            else if((Fuel_value / Fuel_rate) * 100 < km)
            {
                km -= (Fuel_value / Fuel_rate) * 100;
                Probeg += (Fuel_value / Fuel_rate) * 100;
                Fuel_value = 0;
                while (true)
                {
                    Console.WriteLine($"Закончилось топливо, осталось проехать {km:F2}км за {((Fuel_rate * km) / 100):F2}л. Сделать остановку для заправки?\n1) Да\n2) Нет");
                    if (int.TryParse(Console.ReadLine(), out int u_answer))
                    {
                        if (u_answer == 1)
                        {
                            while (true)
                            {
                                Console.WriteLine("Какое кол-во топлива заливаем?");
                                if (double.TryParse(Console.ReadLine(), out double f_value) && f_value > 0)
                                {
                                    Zaprafka(f_value);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("!Некорректное число");
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Stop();
                            km = 0;
                            break;
                        }
                    }
                }
            }
        }
    }
    public void Ostatok()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Остаток топлива: {Fuel_value:F2}");
        Console.ResetColor();
    }
    public void Stop()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Машина остановилась");
        Console.ResetColor();
    }
    public void Razgon()
    {
        Random rnd = new Random();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Машина разгоняется...");
        Console.ResetColor();
        Speed = rnd.Next(30, 100);
    }
    public void Avaria(Avt car)
    {
        Console.WriteLine($"Машина под номером {Avto_number} врезалось в магину под номером {car.Avto_number}");
    }
    public Avt(string avto_number = "", string avto_marka = "", double fuel_value = 0, double fuel_rate = 0, double probeg = 0, double max_fuel_value = 0)
    {
        Avto_number = avto_number;
        Avto_marka = avto_marka;
        Fuel_value = fuel_value;
        Fuel_rate = fuel_rate;
        Probeg = probeg;
        Max_fuel_value = max_fuel_value;
    }

}
