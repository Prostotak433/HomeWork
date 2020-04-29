using System;
using System.Collections.Generic;


namespace Task.w3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] mass1 = new int[100];
            Console.Write("Input the number of elements to be stored in the array : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array: ", num);
            for (int i = 0; i < num; i++)
            {
                Console.Write("element - {0} : ", i);
                mass1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                count = 0;
                for (int j = i+1 ; j < num; j++)
                {
                    if (mass1[i] == mass1[j])
                    {
                        count++;
                    }
                }
                for (int k = i + 1; k < num; k++)
                {
                    if (mass1[i] == mass1[k])
                    {
                        count++;
                    }

                    if (mass1[i] == mass1[i + 1])
                    {
                        i++;
                    }
                }
                if (count == 0)
                {
                    Console.Write("{0} ", mass1[i]);
                }
            }
        }
    }
}
        