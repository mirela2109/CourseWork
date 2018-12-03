using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7 // Задача 360, стр.206
{
    class Program
    {
        private static bool IsInteger(string s)
        {
            if (int.TryParse(s, out int value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string x = "75";
            Console.WriteLine(IsInteger(x));
        }
    }
}
