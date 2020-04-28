using System;

namespace Task.w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            Console.WriteLine("Input 10 elements in the array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements in array are: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", mass[i]);
            }

        }   
    }
}
        