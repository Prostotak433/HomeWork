using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите число длины: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int spc = i + 4-1;
            for (int n = 1; n <= i; n++)
            {
                for (int j = spc; j>=1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < n; k++)
                    Console.Write("* ");
                Console.WriteLine("\n");
                spc--;
               
            }
            
            Console.Read();
          
        }
    }
    
}
