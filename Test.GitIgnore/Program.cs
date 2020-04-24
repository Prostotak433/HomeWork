using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            int flg3=0;
            Console.Write("Input  a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 3; i <= num / 2; i++)
            {
                int flg1 = 1;
                int flg2 = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    { flg1 = 0; j = i; }
                }
                for (int j = 2; j < num - i; j++)
                {
                    if ((num - i) % j == 0)
                    { flg2 = 0; j = num - i; }
                }
                if (flg1 == 1 && flg2 == 1)
                {
                    Console.Write("{0} =  {1} + {2}  \n", num, i, num - i);
                     flg3 = 1;
                }
            }
            if (flg3 == 0)
            { Console.Write("\n{0} can not be expressed as sum of two prime numbers.\n\n", num); }
        }
    }
}

