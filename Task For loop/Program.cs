using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ромба : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 1; j <= a - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            for (int i=a-1; i>=1; i--)
            {
                for(int j=1; j<=a-i; j++)
                    Console.Write(" ");
                for(int j=1; j<=2*i-1; j++)
                    Console.Write("*");
                    Console.Write("\n");
            }
        }
    }
}

