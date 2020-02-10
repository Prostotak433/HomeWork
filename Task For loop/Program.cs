using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало диапазона: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец диапазона: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int fact, a2 = 0,b1=0;
            for (int b = a; b <= a1; b++)
            {
                b1 = b;
                
                for (int i = b; i > 0; i = i / 10)
                {
                    fact = 1;
                    for (int j = 1; j <= i % 10; j++)
                    {
                        fact = fact * j;
                    }
                    a2 = a2 + fact;
                }
            }
            
            if (a2 == b1)
                Console.Write("{0} ", b1);
            
        }    
    }
}


