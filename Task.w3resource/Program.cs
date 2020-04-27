using System;

namespace Task.w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 5, ip = 0;
            for (int i = 0; i <= 6; i++)
            {
                for (int u = 0; u <= 6; u++)
                {
                    if (u == 1 || u == 5 || (i == 2 && (u == 2 || u == 4)) || (i ==3 && u == 3))
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
        