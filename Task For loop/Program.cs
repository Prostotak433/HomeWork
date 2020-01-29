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
            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine("{0} X {1} = {2}",n,i,n*i);
               
            }
            Console.Read();
                
           
        }
    }
    
}
