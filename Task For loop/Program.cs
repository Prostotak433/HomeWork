﻿using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j;
            Console.Write("Введите число: ");
            i = Convert.ToInt32(Console.ReadLine());
            
            for (n = 1; n <= i; n++)
            {
                for (j = 1; j <= n; j++)
                    Console.Write("{0}",j) ;
                Console.Write("\n");

               
            }
            
            Console.Read();
          
        }
    }
    
}
