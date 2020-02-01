using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите значение ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число терминов ");
            int a = Convert.ToInt32(Console.ReadLine());
            int t = 1, sum = 1;
            for(int n =1; n<=a; n++)
            {
                int d = (2 * n) * (2 * n - 1);
                t = -t * i * i / d;
                sum = sum + t;
            }
            Console.WriteLine("\nСумма sum = {0}\nКоличество терминов {1}\nЗначение x = {2} ", sum, a, i);
           
            
            Console.Read();
          
        }
    }
    
}
