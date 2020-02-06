using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            char alph = 'A';
            int ctr = 1;
            Console.Write("Введите длину пирамиды : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                for(int j =1; j <= (ctr/2); j++)
                {
                    Console.Write("{0} ", alph++);
                }
                alph--;
                alph--;
                for(int j=0; j < (ctr/2); j++)
                {
                    Console.Write("{0} ", alph--);
                }
                ctr = ctr + 2;
                alph = 'A';
                Console.Write("\n");
            }
        }    
    }
}


