using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i, a;
            Console.Write("Длина пирамиды : ");
             a = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i <= a; i++)
            { 
                for ( j = 1; j <= a - i; j++)
                    Console.Write(" ");
                for ( j = 1; j <= i; j++)
                    Console.Write("{0} ", j);
                for ( j = i - 1; j >= 1; j--)
                    Console.Write("{0} ", j);

                Console.Write("\n");
            }
        }
    }
}


