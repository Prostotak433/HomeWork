using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, temp;
                        Console.Write("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (temp = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum + (r * r * r);
            }
            if (sum == temp)
                Console.Write("{0} is an Armstrong number.\n", temp);
            else
                Console.Write("{0} is not an Armstrong number.\n", temp);
        }
    }
}

