using System;

namespace Task5 // Задача 375, стр.213
{
    class Program
    {
        private static Random _random = new Random();

        private static double Sred(int k)
        {
            int[] numbers = new int[k];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = _random.Next(-200, 200); // примерен интервал за генериране
            }

            int sum = 0, counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 10 && numbers[i] <= 100)
                {
                    sum += numbers[i];
                    counter++;
                }
            }

            double avg = 0;

            if (counter != 0)
                avg = (double)sum / counter;

            return avg;
        }

        static void Main()
        {
            int[] numbers = new int[32];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = _random.Next(-50, 50);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) // в този интервал всички са положителни 
                {
                    Console.Write($"{numbers[i]} ");
                }
            }

            Console.WriteLine();

            // 2.
            int[] seven = new int[7];

            for (int i = 0; i < seven.Length; i++)
            {
                Console.Write($"Number {i} = ");
                seven[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < seven.Length; i++)
            {
                if (seven[i] < 0 || seven[i] > 200)
                {
                    sum += seven[i];
                }
            }

            Console.WriteLine($"Sum = {sum}");

            // 3.
            Console.Write("Въведете a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Въведете b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Въведете c: ");
            int c = Convert.ToInt32(Console.ReadLine());


            var cc = Sred(Math.Abs(a - b));
            var dd = Sred(c + a);

            double result = Sred(Math.Abs(a - b)) - Sred(c + a);
            Console.WriteLine($"Result = {result}");

            Console.ReadKey();
        }
    }
}
