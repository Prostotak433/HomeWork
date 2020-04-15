using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
                Console.WriteLine("{0} and {1} are equal", a, b);
           
        }
    }
}
