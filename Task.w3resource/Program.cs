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
                    if (u == 1 || ((i == u + 1) && u != 0))
                        Console.Write("*");

                    else if (i == ip && u == k)
                    {
                        Console.Write("*");
                        ip = ip + 1;
                        k = k - 1;
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
        