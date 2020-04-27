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
                    if (((i == 0 || i == 6) && u >= 0 && u <= 6) || i + u == 6)
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
        