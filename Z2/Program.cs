using System;

namespace Prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Числа от 100 до 200, которые кратны трем");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int a = 50;
            int b = 150;
            int c = 5;

            for (int i = a; i <= b; i++)
            {
                if (i % c == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}