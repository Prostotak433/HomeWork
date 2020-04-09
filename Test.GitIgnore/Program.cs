using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.x = 20;
            number.y = 20;
            int sum = number.x + number.y;
            Console.Write("The sum of x and y is {0}\n" ,sum);
            Console.Read();
        }
    }
}
