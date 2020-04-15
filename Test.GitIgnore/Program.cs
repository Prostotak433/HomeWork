using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 400 == 0)
                Console.WriteLine("{0} is a leap year.", a);
            else if (a % 100 == 0)
                Console.WriteLine("{0} is not a leap year.", a);
            else if (a % 4 ==0)
                    Console.WriteLine("{0} is a leap year.", a);
            else
                Console.WriteLine("{0} is not a leap year.", a);
            Console.Read();
        }
    }
}
