using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the desired width: ");
            int b = int.Parse(Console.ReadLine());
            int b1 = b;
            for(int i = 0; i < b1; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                b--;
            }
        }
    }
}

