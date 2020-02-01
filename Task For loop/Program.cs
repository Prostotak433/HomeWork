using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            Console.Write("Введите число терминов ");
            double a = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for(double n =1; n<=a; n++)
            {
                Console.Write("1/{0}+",n);
                sum = sum + 1 / n;
            }
            Console.WriteLine("\nКоличество терминов {0}\nОжидаеммый результат = {1} ", a,sum);
           
            
            Console.Read();
          
        }
    }
    
}
