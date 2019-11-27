using System;

namespace _8._Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите целое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(res(x));
        }
        public static bool res(int x)
        {
            if (Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) <= 20)
                return true;
            return false;
        }
    }
}
