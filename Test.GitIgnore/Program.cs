using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first Integer : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Integer : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Here are the options : ");
            Console.WriteLine("1-Addition.");
            Console.WriteLine("2-Substraction.");
            Console.WriteLine("3-Multiplication.");
            Console.WriteLine("4-Division.");
            Console.WriteLine("5-Exit.");
            Console.Write("Input your choice : ");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("The Addition of  {0} and {1} is: {2}", num1, num2, num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("The Substraction of {0}  and {1} is: {2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("The Substraction of {0}  and {1} is: {2}", num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("The Division of {0}  and {1} is : {2}", num1, num2, num1 / num2);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Input correct option");
                    break;
            }
        }
    }
}

