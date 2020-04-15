using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 != 0)
                Console.WriteLine("{0} is an odd integer", a);
            else
                Console.WriteLine("++"); 
               


        }
    }
}
