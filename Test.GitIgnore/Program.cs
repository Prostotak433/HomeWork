using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of two numbers is : {0}", Sum(a, b));
        }
        public static int Sum(int a, int b)
        {
            int result;
            result = a + b;
            return result;
        }
    }
}
