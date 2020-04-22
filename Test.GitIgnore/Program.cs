using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int poputka = 0, poputok = 0;
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();
                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if (username == "serg433" && password == "123qwe")
                {
                    poputka = 1;
                    poputok = 3;
                }
                else
                {
                    poputka = 0;
                    poputok++;
                }
            }
            while ((username != "serg433") || (password != "123qwe") && (poputok != 3));
            if (poputka == 0)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else
                if(poputka==1)
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }
        }
    }
}

