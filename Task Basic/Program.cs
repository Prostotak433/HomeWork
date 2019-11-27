using System;

namespace Task_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите первое число");
            int a  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a < 0 && b > 0) || (a > 0 && b < 0));
        }
    }
}
