using System;

namespace _2._1_Couditional_Constructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите cумму вклада");
            double sum = Convert.ToDouble(Console.ReadLine());
            double procent = 0;
            if (sum < 100)
            {
                procent = 0.05;
            }
            else if(sum >= 100 && sum <= 200)
            {
                procent = 0.07;
            }
            else
            {
                procent = 0.1;
            }
            sum += sum * procent + 15;

            Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
            Console.ReadKey();
        }
    }
}
