using System;

namespace _12._Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-ое число для проверки меньше 100");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число для проверки меньше 200");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a < 100 && b < 200));
        }
    }
}
