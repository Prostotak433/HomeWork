using System;

namespace Task.w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[100];
            int[] mass2 = new int[100];
            Console.Write("Input the number of elements to be stored in the array : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array: ", num);
            for(int i = 0; i < num; i++)
            {
                Console.Write("element - {0} : ",i);
                mass1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < num; i++)
            {
                mass2[i] = mass1[i];
            }
            Console.Write("The elements stored in the first array are : ");
            for(int i = 0; i < num; i++)
            {
                Console.Write("{0}  ", mass1[i]);
            }
            Console.Write("\n\nThe elements copied into the second array are :\n");
            for (int i = 0; i < num; i++)
            {
                Console.Write("{0}  ", mass2[i]);
            }
        }   
    }
}
        