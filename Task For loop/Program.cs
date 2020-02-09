using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, b = 1, c;
            Console.Write("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            c = a;
            for(int i=a; i>0; i=i/2)
            {
                sum = sum + (a % 2) * b;
                b = b * 10;
                a = a / 2;
            }
            Console.Write("число {0} в {1} ", c, sum);
        }    
    }
}


