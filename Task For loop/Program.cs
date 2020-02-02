using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, t = 9;
            Console.Write("Введите количество терменов ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=a; i++)
            {
                sum += t;
                Console.WriteLine("{0} ", t);
                t = t * 10 + 9;
            }
            Console.Write("Количество терминов {0} " ,sum);
            Console.Read();
          
        }
    }
    
}
