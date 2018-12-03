using System;

namespace Task3 // Тест 2 - Задача 3 - I група, стр.130
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете x:");
            double x = double.Parse(Console.ReadLine());
            double Y = 0;

            if (x < -4)
            {
                Y = (2 * Math.Pow(x, 2)) / (x + 4);
            }
            else if (x >= -4 && x <= 4)
            {
                Y = 0;
            }
            else if (x > 4)
            {
                Y = (Math.Log(x - 4) * Math.Exp(x)) / (Math.Pow(x, 5) + Math.Sqrt(x));
            }

            Console.WriteLine($"Стойността на Y е: {Y}");
        }
    }
}
