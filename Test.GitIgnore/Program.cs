using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Day :");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1: Console.WriteLine("Ponedel");
                    break;
                case 2: Console.WriteLine("Vtornik");
                    break;
                case 3: Console.WriteLine("Sreda");
                    break;
                case 4: Console.WriteLine("Chetverg");
                    break;
                case 5: Console.WriteLine("Pyatnica");
                    break;
                case 6: Console.WriteLine("Sybota");
                    break;
                case 7: Console.WriteLine("Voskrec");
                    break;
                default: Console.WriteLine("Hz 4to tu hochew");
                    break;
            }
        }
    }
}

