using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            Number.x = 10;
            Number.y = 30;
            int sum = Number.x + Number.y;
            Console.Write("The sum of x and y is {0}\n" ,sum);
            Console.Read();
        }
    }
}
