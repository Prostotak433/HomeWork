using System;

namespace Task_for_4_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Red");
            double s = square.Area(3);
            Console.WriteLine(s);
            
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
        public virtual double Area(double a, double h)
        {
            return 1 / 2 * a * h;
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
