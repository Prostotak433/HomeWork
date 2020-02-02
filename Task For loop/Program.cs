using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, p;
            Console.Write("Введите количество терменов ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=a; i++)
            {
                if (i % 2 == 0) { p = 1; q = 0; }
                else {  p = 0;  q = 1; }

                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                        Console.Write("{0} ", p);
                    else
                        Console.Write("{0} ", q);
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
    
}
