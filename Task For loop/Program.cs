using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Веедите  число");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Число {0} и куб из {0} равен {1}",i,i*i*i);
               
            }
            Console.Read();
                
           
        }
    }
    
}
