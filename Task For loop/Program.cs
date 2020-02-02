using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Значение Х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество Терминов: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double t = 1, sum=0;
            for(double i = 1, step =1; i < a+1; i++)
            {
                double math = Math.Pow(x, step);
                sum = sum + math * t;
                t = t * (-1);
                step = step * 2;
            }
            Console.Write("\nСумма {0}\nКоличество терминов {1}\nX={2} ", sum, a, x);
        }
    }

}
