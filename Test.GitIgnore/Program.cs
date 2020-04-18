using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Month(1-12) : ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("Month have 28-29 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month have 30 days");
                    break;
                default:
                    Console.Write("invalid Month number.\nPlease try again ....\n");
                    break;
            }
        }
    }
}

