using System;

namespace Task_for_4_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
            IFigure square = figure.create("Square");
            double s1= square.Area();
            IFigure rectangle = figure.create("Reactangle");
            double s2 = rectangle.Area();
            IFigure triangle = figure.create("Triangle");
            double s3 = rectangle.Area();
            IFigure circle = figure.create("Circle");
            double s4 = rectangle.Area();
            Console.Write("Фигура {0} имеет площадь {1}\nФигура {2} имеет площадь {3}\nФигури {4} имеет площадь {5}\n" +
                "Фигури {6} имеет площадь {7} ", square, s1, rectangle, s2, triangle, s3, circle, s4);


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
