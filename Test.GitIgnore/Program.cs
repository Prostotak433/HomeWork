using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
           string str1 = "";
            Console.Write("Input  A String : ");
            string str = Console.ReadLine();
            int l = str.Length - 1;
            for (int i = l; i >= 0; i--)
            {
                 str1 = str1 + str[i];
            }
            Console.WriteLine(str1);
        }
    }
}

