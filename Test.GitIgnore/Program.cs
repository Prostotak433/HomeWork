using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}   {1}", num,Factorial(num)); 
        }
        public static int Factorial(int num1)
        {
            if (num1 == 0)
                return 1;
            else
                return num1 * Factorial(num1 - 1);
        }
    }
}
