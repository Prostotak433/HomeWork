using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The height of a person: ");
            int m = int.Parse(Console.ReadLine());

            if (m < 150)
                Console.WriteLine("The prson is  Dwarf ");
            else if ((m >= 150) && (m <= 165))
                Console.WriteLine("The person is  average heighted");
            else if ((m >= 165.0) && (m <= 195.0))
                Console.Write("The person is taller. ");
            else
                Console.Write("Abnormal height.");
        }
    }
}
