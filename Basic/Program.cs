using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 -ое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 -ое число");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = Sum(a, b);
            Console.WriteLine(result);
        }
        public static int Sum(int a, int b)
        {
            return a == b ? (a + b) * 3 : (a + b);
        }
    }
    
}
