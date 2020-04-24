using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i <= 7; i++)
           {
                for(int u = 0; u <= 7; u++)
                {
                    if (((u == 1 || u == 5) && i != 0) || ((i == 0 || i == 3) && (u > 1 && u < 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

        }
    }
}

