using System;

namespace Task2 // Тест 1 - Задача 7 - II група, стр.129
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете височина H: ");
            double H = double.Parse(Console.ReadLine());
            Console.Write("Въведете радиус R: ");
            double R = double.Parse(Console.ReadLine());
            double s = 2 * R * H * Math.PI;
            double S = 2 * R * H * Math.PI + 2 * R * R * Math.PI;

            Console.WriteLine("Лицето на околната повърхнина s:" + s);
            Console.WriteLine("Лицето на пълната повърхнина S:" + S);
        }
    }
}
