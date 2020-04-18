using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1 for area of circle");
            Console.WriteLine("Input 2 for area of rectangle");
            Console.WriteLine("Input 3 for area of triangle");
            Console.WriteLine("Input your choice : ");
            int num = int.Parse(Console.ReadLine());
            double area=0;
            switch(num)
            {
                case 1:
                    Console.Write("Input radius of the circle : ");
                    double r = double.Parse(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;
                case 2:
                    Console.Write("Input length  of the rectangle : ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    double b = Convert.ToInt32(Console.ReadLine());
                    area = a * b;
                    break;
                case 3:
                    Console.Write("Input the base of the triangle :");
                    double j = double.Parse(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                    double h = double.Parse(Console.ReadLine());
                    area = .5 * j * h;
                    break;
            }
            Console.Write("The area is : {0}\n", area);
        }
    }
}

