using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            Console.Write("Input the Roll Number of the student : ");
            double student = double.Parse(Console.ReadLine());
            Console.Write("Input the Name of the Student : ");
            string name = Console.ReadLine();
            Console.Write("Input the marks of Physics: ");
            double physics = double.Parse(Console.ReadLine());
            Console.Write("Input the marks of Chemistry: ");
            double chemisry = double.Parse(Console.ReadLine());
            Console.Write("Input the marks of Computer Application: ");
            double computer = double.Parse(Console.ReadLine());

            double total = (physics + chemisry + computer);
            double sred = total / 3.0;
            if (sred >= 90)
                result = "Best";
            else
                if (sred < 90 && sred >= 75)
                result = "Second";
            else
                if (sred < 75 && sred >= 60)
                result = "Bad";
            else
                result = "Fail";
            Console.Write("\nRoll No : {0}\nName of Student : {1}\n", student, name);
            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", physics, chemisry, computer);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, sred, result);
        }
    }
}

