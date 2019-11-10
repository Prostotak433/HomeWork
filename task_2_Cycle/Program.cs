using System;

namespace task_2_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите срок вклада в месяцах: ");
            int period = Convert.ToInt32(Console.ReadLine());
            int i = 1;                    //  i = period
            while(i < period)             // (i > 0)
            {
                sum += sum * 0.07M;
                i++;
            }
            Console.WriteLine($"После {period} месяцев сумма вклада составит {sum}");
            Console.ReadKey();
        }
    }
}
