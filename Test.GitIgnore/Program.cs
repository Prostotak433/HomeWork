using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            double coef, sumproc = 0, sumall;
            Console.Write("Input IDNO: ");
            double idno = double.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Consumed : ");
            double cons = double.Parse(Console.ReadLine());
            if (cons <= 199)
            {
                coef = 1.20;
            }
            else if (cons >= 200 && cons < 400)
            {
                 coef = 1.50;
            }
            else if (cons >= 400 && cons < 600)
            {
                 coef = 1.80;
            }
            else
            {
                coef = 2.00;
            }
            double sum = cons * coef;
            if (sum > 300)
                sumproc = (sum * 15) / 100;
            sumall = sumproc + sum;
            Console.Write("\nCustomer IDNO                    :{0}\n",idno);
            Console.Write("Customer Name                      :{0}\n", name);
            Console.Write("unit Consumed                      :{0}\n", cons);
            Console.Write("Amount Charges @Rs. {0} per unit   :{1}\n", coef, sum);
            Console.Write("Surchage Amount                    :{0}\n", sumproc);
            Console.Write("Net Amount Paid By the Customer    :{0}\n", sumall);
        }
        
    }
}

