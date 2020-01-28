using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum=0;
            double sred = 0;
            Console.WriteLine("Веедите 10 чисел");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Номер {0} ", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            sred = sum / 10.0;
            Console.Write("Cумма: {0}\nСреднее значение {1}\n",sum,sred );
                
           
        }
    }
    
}
