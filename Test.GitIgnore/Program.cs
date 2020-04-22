using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a symbol: ");
            char symvol = Convert.ToChar(Console.ReadLine());
            if ((symvol == 'a') || (symvol == 'e') || (symvol == 'i') || (symvol == 'o') || (symvol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symvol >= '0') && (symvol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
        }
    }
}

