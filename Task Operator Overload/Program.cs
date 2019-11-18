using System;

namespace Task_Operator_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            State Russian = new State { Area = 300, Population = 3000 };
            State Ukranian = new State { Area = 100, Population = 2000 };
            State SSSR = Ukranian + Russian;
            Console.WriteLine(SSSR.Population);
            if (Russian > Ukranian)
            {
                Console.WriteLine("Russia bol6we Ukr");
            }
            else
            {
                Console.WriteLine("Russia men6we Ukr");
            }
        }
    }
}
