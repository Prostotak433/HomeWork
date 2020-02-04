using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prost = true;
            Console.Write("Введите число : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=2; i<=a/2; i++)   
            {
                if(a%i==0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();
        }
    }
}


