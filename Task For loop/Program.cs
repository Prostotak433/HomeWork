using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, num1 = 0, num2 = 1;
            Console.Write("Введите количество членов ряда Фибоначи: ");
            int afib = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}  {1} ", num1, num2);
            for(int i =3; i<=afib; i++)
            {
                sum = num1 + num2;
                Console.Write("{0} ",sum);
                num1 = num2;
                num2 = sum;
            }
            Console.Write("\n");
        }
    }
}


