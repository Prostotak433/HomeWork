using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Веедите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum  += i;
                Console.Write("{0} ", i);
            }
            Console.Write("Cумма: {0}", sum);
                
           
        }
    }
    
}
