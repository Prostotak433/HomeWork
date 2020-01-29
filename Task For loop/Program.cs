using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j;
            Console.WriteLine("Введите число");
            j = Convert.ToInt32(Console.ReadLine());
            for (n = 1; n <= 8; n++)
            {
                for (i = 1; i <= j; i++)
                {
                    if(i<=j)
                    Console.Write("{0}X{1}={2}  ", n, i, n * i);
                }
                Console.Write("\n");
            }

            Console.Read();
          
        }
    }
    
}
