using System;

namespace _10_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            string[] mass = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string zam = "";
            int b = 0;

            foreach(string a in mass)
            {
                if(a.Length>0)
                {
                    zam = a;
                    b = a.Length;  
                }
            }
            Console.WriteLine(zam);
        }
    }
}
