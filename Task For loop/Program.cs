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
            for (int i = a; i != 0; i = i / 10)
            {
                int r = i % 10;
                sum = sum * 10 + r;
            }
            Console.Write("{0} \n", sum);

            // код не из книги
            Console.Write(a % 10);
            while ((a /= 10) != 0)
                Console.Write(a % 10);
        }
    }
}


