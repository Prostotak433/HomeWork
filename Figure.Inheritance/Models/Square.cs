using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Inheritance
{
    class Square : IFigure
    {
        private double _sideA;
        public Square(double sideA)
        {
            _sideA = sideA;
        }
        public double Area() { return _sideA * _sideA; }
        public override string ToString()
        {
            return $"Area of a Square = {Area()} ";
        }
    }
}
