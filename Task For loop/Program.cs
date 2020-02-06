using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i;
            Console.Write("Введите число : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for ( i = a; i != 0; i = i / 10)
            {
                int r = i % 10;
                sum = sum * 10 + r;
            }
            if (i == sum)
                Console.Write("Полиндром {0} ", i);
            else
                Console.Write("Не полиндром {0} ", i);

        }    
    }
}


