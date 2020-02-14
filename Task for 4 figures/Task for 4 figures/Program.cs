using System;

namespace Task_for_4_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("ABDC", "Red");
            square.Display();
            
            
        } 
    }

    class Figure
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Figure(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public virtual void Display()
        {
            Console.Write("Name = {0}, Color = {1} ", Name, Color);
        }
    }
    class Square:Figure
    {
        public Square(string name, string color) : base(name, color) { }
        static int Area()
        {
            int a = 3;
            int s1 = a * a;
            return s1;
            
        }
        public override void Display()
        {
            Console.Write("Name = {0}, Color = {1}, Area = {2} ", Name, Color);
        }
    }

}
