using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.Write("Book: ");
            int x = int.Parse(Console.ReadLine());
            SructNumber[] sructNumbers = new SructNumber[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Information of book {0}: ", a);

                Console.Write("Input name of the book : ");
                sructNumbers[i].name = Console.ReadLine();

                Console.Write("Input the author: ");
                sructNumbers[i].author = Console.ReadLine();
                a++;
                Console.WriteLine();
            }
            for(int j =0; j < x; j++)
            {
                Console.WriteLine("{0}: Title = {1},  Author = {2}", j + 1, sructNumbers[j].name, sructNumbers[j].author);
            }
            Console.Read();
        }
    }
}
