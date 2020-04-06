using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string : ");
            string text = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\""+text+"\""+ "contains {0} spaces", Space(text));

        }
        public static int Space(string str)
        {
            int res = 0;
            string str1;
            for(int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    res++;
            }
            return res;
        }
    }
}
