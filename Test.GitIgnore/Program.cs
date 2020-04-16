using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input value of a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input value of b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input value of c: ");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0) Console.WriteLine("Dont have a root");
            else
            {
                double x1 = -(b - Math.Sqrt(d)) / (2 * a);
                double x2 = -(b + Math.Sqrt(d)) / (2 * a);
                if (x1 == x2) Console.WriteLine("Have 1 root x={0}", x1);
                else Console.WriteLine("Have 2 root x1={0} and x2={1}", x1, x2);
            }
        }
    }
}

