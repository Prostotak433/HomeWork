using System;

namespace Task.w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int u = 0; u <= 6; u++)
                {
                    if (((i == 0 || i == 3 || i == 6) && u > 1 && u < 5) || (u == 1 && (i == 1 || i == 2 || i == 6)
                        || (u == 5 && (i == 0 || i == 4 || i == 5 ))))
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
        