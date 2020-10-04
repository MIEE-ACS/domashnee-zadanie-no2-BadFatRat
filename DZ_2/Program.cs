using System;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус R = ");
            double R = CheckR(Console.ReadLine());
            if (R < 3)
                Console.WriteLine("Функция не определена.");
            for (double x = -6 - R; x <= -3; x += 0.2) 
            {
                if (x < -6)
                    Console.WriteLine($"y({x:0.0}) = {Sector1(R, x):0.00}");
                else if (x <= -3)
                    Console.WriteLine($"y({x:0.0}) = {Sector2(x):0.00}");
            }
            if (R < 3)
            {
                Console.WriteLine($"y({-3.0:0.0}) = {Sector2(-3.0):0.00}");
                Console.WriteLine($"Функция не определена на промежутке (-3; {-R})");
            }
            for (double x = 0 - R; x <= 9; x += 0.2) 
            {
                if (x < 0)
                    Console.WriteLine($"y({x:0.0}) = {Sector3(R, x):0.00}");
                else if (x < 3)
                    Console.WriteLine($"y({x:0.0}) = {Sector4(x):0.00}");
                else if (x < 9)
                    Console.WriteLine($"y({x:0.0}) = {Sector5(x):0.00}");
            }
            Console.WriteLine($"y({9.0:0.0}) = {Sector5(9.0):0.00}");
        }
        static double CheckR(string user_input) // проверяет, является ли введённое значение числом типа double в нужном диапазоне (0 < R <= 3)
        {
            if (double.TryParse(user_input, out double value))
                if (value > 0 && value <= 3)
                    return value;
            Console.WriteLine("Введённая вами строка не является нужным числом. Конец программы.");
            Environment.Exit(0);
            return 0;
        }
        static double Sector1(double R, double x)
        {
            double y = -Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x + 6.0, 2));
            return y;
        }
        static double Sector2(double x)
        {
            double y = x + 3.0;
            return y;
        }
        static double Sector3(double R, double x)
        {
            double y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2));
            return y;
        }
        static double Sector4(double x)
        {
            double y = -x + 3.0;
            return y;
        }
        static double Sector5(double x)
        {
            double y = x / 2.0 - 1.5;
            return y;
        }
    }
}