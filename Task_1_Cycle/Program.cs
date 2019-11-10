using System;

namespace Task_1_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев");
            int period = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<=period; i++)
            {
                sum += sum * 0.07M;
            }
            Console.WriteLine($"После {period} сумма вклада состовялет {sum}");
            Console.ReadKey();
        }
    }
}
