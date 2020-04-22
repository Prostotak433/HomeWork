using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            double r = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            Console.WriteLine(4 * PI * (r * r));
            Console.WriteLine(4/3 * PI * (r * r * r));
        }
    }
}

