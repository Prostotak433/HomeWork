using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Console.WriteLine("Input the radius of the circle : ");
            double r = Convert.ToDouble(Console.ReadLine());
            double per = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle : {0}", per);
            Console.Read();
        }
    }
}

