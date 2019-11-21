using System;

namespace _2Task_Overloading_Type_Conversion_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius celcius = new Celcius { Gradus = 25 };
            Fahrenheit fahrenheit = celcius;
            Console.WriteLine(fahrenheit.Gradus);
            celcius = fahrenheit;
            Console.WriteLine(celcius.Gradus);
        }
    }
    class Celcius
    {
        public double Gradus { get; set; }
        public static implicit operator Celcius(Fahrenheit fahrenheit)
        {
            return new Celcius { Gradus = 5.0 / 9.0 * (fahrenheit.Gradus - 32) };
        }
        public static implicit operator Fahrenheit(Celcius celcius)
        {
            return new Fahrenheit { Gradus = 9.0 / 5 * (celcius.Gradus + 32) };
        }
        
    }
    class Fahrenheit
    {
        public double Gradus { get; set; }
    }
}
