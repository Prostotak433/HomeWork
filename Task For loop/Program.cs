using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int a1 = a,a2=0, fact;
            for(int i = a; i>0; i=i/10)
            {
                fact = 1;
                for(int j=1; j<=i%10 ;j++)
                {
                    fact = fact * j;
                }
                a2 = a2 + fact;
            }
            if (a1 == a2)
                Console.Write("Сильное число {0} ", a1);
            else
                Console.Write("Число не сильное {0} ", a1);
        }    
    }
}


