using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input  any Decimal number: ");
            int decn = Convert.ToInt32(Console.ReadLine());
            int q = decn;
            for (int i = q; i > 0; i = i / 16)
            {
                int tmp = i % 16;
                if (tmp < 10)
                    tmp = tmp + 48;
                else
                    tmp = tmp + 55;
                int dn = dn * 100 + tmp;
            }
            Console.Write("\nThe equivalent Hexadecimal Number : ");
            for (int j = dn; j > 0; j = j / 100)
            {
                int s = j % 100;
                Console.Write("{0}", (char)s);
            }
            Console.Write("\n\n");
        }
    }
}

