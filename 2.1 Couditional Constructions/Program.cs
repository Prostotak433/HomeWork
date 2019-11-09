using System;

namespace _2._1_Couditional_Constructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-oe число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-oe число");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("1-oe Число больше 2-го");
            }
            else if(num1 < num2)
            {
                Console.WriteLine("2-oe число больше 1 - го");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
            Console.ReadKey();
        }
    }
}
