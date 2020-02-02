using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1, peremen = 1;
            Console.Write("Введите значение Х: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество терминов: ");
            double a = Convert.ToInt32(Console.ReadLine());
            for(double i = 1; i<a;i++)
            {
                peremen = peremen * x / i;
                sum = sum + peremen;
            }
            Console.Write("\nCумма {0}\nКоличество терминов {1}\nЗначение Х: {2} ", sum, a, x);
            Console.Read();
        }
    }
    
}
