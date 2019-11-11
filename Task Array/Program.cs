using System;

namespace Task_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

            int a = mas.GetUpperBound(0) + 1;
            int b = mas.GetUpperBound(1) + 1;
            int c = mas.GetUpperBound(2) + 1;
            Console.Write("{");
            for (int i = 0; i < a; i++)
            {
                Console.Write("{");
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < c; k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k < c - 1)
                            Console.Write(",");
                    }
                    if (j < b - 1)
                        Console.Write(",");
                }
                if (i < a - 1)
                    Console.Write(",");
            }
            Console.ReadKey();
        }
    }
}
