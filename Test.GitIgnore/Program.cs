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
            int res = a1 + a2 + a3;
            if (res == 180) Console.WriteLine("Можно построить треугольник");
            else Console.WriteLine("Треугольник недействителен");
        }
    }
}

