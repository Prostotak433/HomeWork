using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 
            Console.Write("Введите число длины: ");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <= i; n++)
            {
                Console.Write("{0} ", 2 * n);
                sum += 2*n;

            }

            Console.WriteLine("Сумма натуральных чисел {0} равно {1}",i, sum);   
            
            Console.Read();
          
        }
    }
    
}
