using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Input operation: ");
            char oper = char.Parse(Console.ReadLine());
            if (oper == '+') Console.WriteLine("Expected Output: {0} + {1} = {2}", num1, num2, num1 + num2);
            else if (oper == '-') Console.WriteLine("Expected Output: {0} - {1} = {2}", num1, num2, num1 - num2);
            else if (oper == '*') Console.WriteLine("Expected Output: {0} * {1} = {2}", num1, num2, num1 * num2);
            else if (oper == '/') Console.WriteLine("Expected Output: {0} / {1} = {2}", num1, num2, num1 / num2);
            else Console.WriteLine("Wrong Character");
        }
    }
}

