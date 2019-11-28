using System;

namespace _13_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((-10 < a && a < 10));
        }
    }
}
