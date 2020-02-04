using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Введите количество строк : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 1; j <= a - i; j++)
                    Console.Write("  ");
                for (int n = 0; n <= i; n++)
                {
                    if (n == 0 || i == 0)
                        sum = 1;
                    else
                        sum = sum * (i - n + 1) / n;
                    Console.Write("{0}    ", sum);
                }
                Console.Write("\n");
            }
        }
    }
}


