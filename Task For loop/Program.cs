using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Введите число : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                    Console.Write("{0} ", i);
                }
            }
            Console.Write("Сумма делителей {0} ", sum);
        }
    }
}
