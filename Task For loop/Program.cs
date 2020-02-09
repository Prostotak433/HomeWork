using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int deli = 1;
            Console.Write("Введите 1-ое число: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ое число: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int j = (a1 < a2) ? a1 : a2;
            for(int i=1; i<=j; i++)
            {
                if(a1%i==0 && a2%i==0)
                {
                    deli = i;
                    Console.WriteLine("{0} ", deli);
                }
            }
            Console.Write("Количество делителей {0} i {1} равно {2} ", a1, a2, deli);
        }    
    }
}


