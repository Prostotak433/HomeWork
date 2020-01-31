using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1; 
            Console.Write("Введите число длины: ");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <= i; n++)
            {
                f = f * n;

            }  
            
            Console.WriteLine("Факториал числа {0} равен {1} ", i, f);   
            
            Console.Read();
          
        }
    }
    
}
