using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, b = 1,d,p=1, c;
            Console.Write("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            c = a;
            for(int i=a; i>0; i=i/10)
            {
                d = i % 10;
                if (b == 1)
                    p *= 1;
                else
                    p *= 2;
                sum = sum + (d * p);
                b++;
            }
            Console.Write("число {0} в {1} ", c, sum);
        }    
    }
}


