using System;

namespace Task_for_4_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            Square square = (Square)figure.create("Square");
            double s1= square.Area();
            
            Console.Write("Фигура {0} имеет площадь {1} ", square, s1);
            

        } 
    }
    interface IFigure
    {
        double Area();
    }
    class Square:IFigure
    {
        double a;
        public Square(double a)
        {
            this.a = a;
        }
        public  double  Area()
        {
            return a * a;
        }
    }
    class Rectangle:IFigure
    {
        double c, b;
        public Rectangle(double c,double b)
        {
            this.c = c;
            this.b = b;
        }
        public double Area()
        {
            return c * b;
        }
    }
    class Triangle:IFigure
    {
        double a, b;
        public Triangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Area()
        {
            return (a * b) / 2;
        }
    }
    class Circle:IFigure
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public double Area()
        {
            return 3.14 * r * r;
        }
    }
    class Figure
    {
        public IFigure create(string typeOfIFigure)
        {
            switch(typeOfIFigure)
            {
                case "Square": return new Square(3);
                case "Rectangle:": return new Rectangle(5, 4);
                case "Triangle": return new Triangle(2,3);
                case " Circle":return new Circle(3);
                default:return null;

            }
        }
    }
}
