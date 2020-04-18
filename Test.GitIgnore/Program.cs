using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Input the grade : ");
            char grade = char.Parse(Console.ReadLine().ToUpper());
            string a1;
            switch(grade)
            {
                case 'E':
                    a1 =("Excellent");
                    break;
                case 'V':
                    a1 =("Very good");
                    break;
                case 'G':
                    a1 = ("Good");
                    break;
                case 'A':
                    a1 = ("Average");
                    break;
                case 'F':
                    a1 =("Fail");
                    break;
                default:
                    a1 = "Invalid Grade Found.";
                    break;
            }
            Console.Write("You have chosen  : {0}\n", a1);
        }
        
    }
}

