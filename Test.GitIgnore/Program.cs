using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int num2 = int.Parse(Console.ReadLine());
            bool res = ((num1 % 2 == 0) && (num2 % 2 == 0)) ? true : false;
            Console.WriteLine(res);
        }
    }
}

