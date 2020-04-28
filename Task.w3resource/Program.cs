using System;

namespace Task.w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[100];
            Console.Write("Input the number of elements to store in the array : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array: ", num);
            for (int i = 0; i < num; i++)
            {
                Console.Write("element - {0} : ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements in array are: ");
            for(int i = 0; i < num; i++)
            {
                Console.Write("{0} ", mass[i]);
            }
            Console.WriteLine("\nThe values store into the array in reverse are: ");
            for(int i = num - 1; i >= 0; i--)
            {
                Console.Write("{0} ", mass[i]);
            }
        }   
    }
}
        