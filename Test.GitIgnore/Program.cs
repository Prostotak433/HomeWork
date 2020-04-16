using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Physics : ");
            int ph = int.Parse(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry : ");
            int ch = int.Parse(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics ");
            int mt = int.Parse(Console.ReadLine());
            Console.WriteLine("Total marks of Maths, Physics and Chemistry: {0}",ph+ch+mt);
            Console.WriteLine("Total marks of Maths  and Physics: {0}", ph + mt);

            if (ph >= 65)
            {
                if (ch >= 55)
                {
                    if (mt >= 50)
                    {
                        if ((ph + ch + mt) >= 180 || (mt + ph) >= 140)
                            Console.WriteLine("The  candidate is eligible for admission.");
                    }
                    else
                        Console.Write("The candidate is not eligible.");
                }
                else
                    Console.Write("The candidate is not eligible.");
            }
            else
                Console.Write("The candidate is not eligible.");
        }
    }
}

