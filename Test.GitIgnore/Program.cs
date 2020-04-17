using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-угол : ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("2-угол : ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("3-угол : ");
            int a3 = int.Parse(Console.ReadLine());

            if ((a1 == a2) && (a2 == a3)) Console.WriteLine("This is an equilateral triangle.");
            else if (a1 == a2 || a1 == a3 || a2 == a3)  Console.Write("This is an isosceles triangle.");
            else Console.Write("This is a scalene triangle.");

        }
    }
}

