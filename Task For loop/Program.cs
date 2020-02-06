using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i;
            Console.Write("Введите число : ");
            int amin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число : ");
            int amax = Convert.ToInt32(Console.ReadLine());
            for ( i = amin; i<= amax; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0} ", i);
                    sum += i;
                }
            }
            Console.Write("Сумма {0} ", sum);
            

        }    
    }
}


