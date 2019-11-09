using System;

namespace _2._1_Couditional_Constructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 5 || 10 == num1)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
            Console.ReadKey();
        }
    }
}
