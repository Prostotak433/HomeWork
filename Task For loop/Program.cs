using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,sum=0;
            Console.Write("Введите число: ");
            i = Convert.ToInt32(Console.ReadLine());
            
            for (n = 1; n <= i; n++)
            {
                Console.WriteLine("{0}",2*n-1);
                sum += 2 * n - 1;
               
            }
            Console.Write("\nСумма чисел {0} = {1}\n ", i, sum);
            Console.Read();
          
        }
    }
    
}
