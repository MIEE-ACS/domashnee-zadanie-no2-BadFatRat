using System;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус R = ");
            double R = CheckR(Console.ReadLine());
            double x1 = -6 - R;
            double x2 = -R;
            if (R > 3)
            {
                x1 = -9;
                x2 = -3;
            }
            else if (R == 0)
                Console.WriteLine($"y({-6:0.0}) = {0:0.###}");
            else if (R != 3)
            {
                x1 = CuteConsoleOutput(x1);
                x2 = CuteConsoleOutput(x2);
                Console.WriteLine($"Функция не определена на промежутке [-9, {-6 - R:0.###}).");
            }
            for (double x = x1; x <= -3; x += 0.2) 
            {
                if (Math.Round(x, 1) == -6.0 && R != 0 && R != 3)
                    Console.WriteLine($"y({-6:0.0}) = {Sector1(R, x):0.###}");
                if (x < -6.0)
                    Console.WriteLine($"y({x:0.0}) = {Sector1(R, x):0.###}");
                else if (x <= -3.0)
                    Console.WriteLine($"y({x:0.0}) = {Sector2(x):0.###}");
            }
            if (R < 3)
            {
                Console.WriteLine($"y({-3.0:0.0}) = {Sector2(-3.0):0.###}");
                Console.WriteLine($"Функция не определена на промежутке (-3; {-R:0.###})");
            }
            if (R == 0)
                Console.WriteLine($"y({0:0.0}) = {0:0.###}");
            for (double x = x2; x <= 9.0; x += 0.2) 
            {
                if (CuteConsoleOutput(x) == 0.0 && R != 0.0)
                    Console.WriteLine($"y({0:0.0}) = {Sector3(R, x):0.###}");
                if (CuteConsoleOutput(x) < 0.0)
                        Console.WriteLine($"y({x:0.0}) = {Sector3(R, x):0.###}");
                else if (x < 3.0)
                    Console.WriteLine($"y({Math.Abs(x):0.0}) = {Sector4(x):0.###}");
                else if (x < 9.0)
                    Console.WriteLine($"y({x:0.0}) = {Sector5(x):0.###}");
                
            }
            Console.WriteLine($"y({9.0:0.0}) = {Sector5(9.0):0.###}");
        }
        static double CheckR(string user_input) // проверяет, является ли введённое значение числом типа double в нужном диапазоне (0 >= R)
        {
            if (double.TryParse(user_input, out double value))
                if (value >= 0.0)
                    return value;
            Console.WriteLine("Введённая вами строка не является нужным числом. Конец программы.");
            Environment.Exit(0);
            return 0;
        }
        static double CuteConsoleOutput(double x)
        {
            x = Math.Truncate(x * 10.0) / 10.0;
            return x;
        }
        static double Sector1(double R, double x)
        {
            double y = -Math.Sqrt(Math.Abs(Math.Pow(R, 2) - Math.Pow(x + 6.0, 2)));
            if (y > -0.001)
                return 0.0;
            return y;
        }
        static double Sector2(double x)
        {
            double y = x + 3.0;
            return y;
        }
        static double Sector3(double R, double x)
        {
            double y = Math.Sqrt(Math.Abs(Math.Pow(R, 2) - Math.Pow(x, 2)));
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