using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество людей: ");
            int people = int.Parse(Console.ReadLine());
            
            Number[] numb = new Number[people];
            for(int i = 0; i < people; i++)
            {
                Console.Write("Name of the employee : ");
                string name = Console.ReadLine();
                numb[i].Name = name;

                Console.Write("Input day of the birth : ");
                int day = int.Parse(Console.ReadLine());
                numb[i].Day = day;

                Console.Write("Input month of the birth : ");
                int month = int.Parse(Console.ReadLine());
                numb[i].Month = month;

                Console.Write("Input year for the birth : ");
                int year = int.Parse(Console.ReadLine());
                numb[i].Year = year;
            }
            Console.Read();
        }
    }
}
