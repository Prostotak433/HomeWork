using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Cost Price: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input Selling Price: ");
            int sel = int.Parse(Console.ReadLine());
            if (sel > start)
            {
                int sum = sel - start;
                Console.WriteLine("You can booked your profit amount: {0}", sum);
            }
            else if (start > sel)
            {
                int sum = start - sel;
                Console.Write("You got a loss of amount : {0}", sum);
            }
            else Console.WriteLine("You are running in no profit no loss condition.");
        }
    }
}

