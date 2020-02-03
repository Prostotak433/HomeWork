using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, r, sum, temp;
            int stno, enno;
            Console.Write("Input starting number of range: ");
            stno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range : ");
            enno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Armstrong numbers in given range are: ");
            for (num = stno; num <= enno; num++)
            {
                temp = num;
                sum = 0;

                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == num)
                    Console.Write("{0} ", num);
            }
        }
    }
}

