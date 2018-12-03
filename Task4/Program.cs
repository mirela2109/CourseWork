using System;

namespace Task4 // Задача 87 - Б), стр.61
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("*");
                for (int j = 1; j <= 7 - i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
