﻿using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.Write("{0} ", i);
            }
            Console.Write("Cумма: {0}", sum);
                
           
        }
    }
    
}
