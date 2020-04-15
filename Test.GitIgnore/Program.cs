using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Value: ");
            int m = int.Parse(Console.ReadLine());
            if (m > 0)
                Console.WriteLine("The value of n = 1");
            else if (m == 0)
                Console.WriteLine("The value of n = 0");
            else
                Console.WriteLine("Value of m ={0} The value of n = -1", m);
        }
    }
}
