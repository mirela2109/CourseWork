using System;

namespace Task6 // Задача 406, стр.222
{
    public static class ExtensionMethods
    {
        public static double Average(this int[] numbers, int k)
        {
            double avg = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= -10 && numbers[i] <= 10 && numbers[i] % k == 0)
                {
                    avg += numbers[i];
                }
            }

            return avg;
        }

        public static void Max(this int[] numbers, out int max, out int index)
        {
            max = numbers[0];
            index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    index = i;
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            int n = 0, k = 0;

            while (n <= 2 || n >= 60)
            {
                Console.Write("Въведете n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i} = ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Това е A)
            Console.Write("Въведете k: ");
            while (k <= 0)
            {
                k = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Avg = {numbers.Average(k)}");

            // Това е Б)
            numbers.Max(out int max, out int index);
            Console.WriteLine($"Max = {max}, index = {index}");

            Console.ReadKey();
        }
    }
}