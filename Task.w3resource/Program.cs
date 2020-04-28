using System;

namespace Task.w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] mass = new int[100];
            Console.Write("Input the number of elements to be stored in the array : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array ", num);
            for(int i = 0; i < num; i++)
            {
                Console.Write("element - {0} : ", i);
                mass[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
            }
            Console.Write("Sum of all elements stored in the array is : {0}", sum);        
        }   
    }
}
        