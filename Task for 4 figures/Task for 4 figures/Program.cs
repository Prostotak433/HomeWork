using System;

namespace Task_for_4_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Red");
            double s1 = square.Area(3);
            Console.Write("Площадь квардата = {0} ",s1);
            Rectangle rectangle = new Rectangle("Green");
            double s2 = rectangle.Area(5);
            Console.Write("\nПлощадь прямоугольника = {0} ", s2);
            Triangle triangle = new Triangle("Blue");
            double s3 = triangle.Area(2,3);
            Console.Write("\nПлощадь треугольника = {0} ", s3);
            Circle circle = new Circle("Yellow");
            double s4 = circle.Area(3);
            Console.Write("\nПлощадь круг = {0} ", s4);

            double[] i =  { s1, s2, s3, s4 };
            double max = double.MinValue;
            for (int j = 0; j < i.Length; j++)
            {
                if (i[j] > max)
                {
                    max = i[j];
                }
            }
            Console.WriteLine("\nНайбольшая площадь  {0} ", max);

        } 
    }
    class Square
    {
        public string Color { get; set; }
        public Square(string color)
        {
            Color = color;
        }
        public virtual double Area(double a)
        {
            return a*a;
        }
    }
    class Rectangle : Square
    {    
        public Rectangle(string color): base(color) { }
        public virtual double Area(double a, double b)
        {
            return a * b;
        }
    }
    class Triangle:Square
    {
        public Triangle(string color) : base(color) { }
        public virtual double Area(double k, double h)
        {
            return (k*h)/2;
        }
    }
    class Circle : Square
    {
        public Circle(string color) : base(color) { }
        public override double Area(double r)
        {
            return 3.14 * r * r;
        }
    }

}
