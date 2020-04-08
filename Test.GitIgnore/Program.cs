using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Fibonacci of {0} th term is {1}", num, Fibonachi(num));
            
        }
        public static int Fibonachi(int num1)
        {
            if (num1 <= 2)
                return 1;
            else
                return Fibonachi(num1 - 1) + Fibonachi(num1 - 2);
        }
    }
}
