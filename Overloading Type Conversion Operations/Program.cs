using System;

namespace Overloading_Type_Conversion_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            int x = 34;
            clock.Hours = x % 24;
            x = clock.Hours;
        }
    }
    class Clock
    {
        public int Hours { get; set; }
        public static implicit operator Clock(int x)
        {
            return new Clock { Hours = x % 24 };
        }
        public static explicit operator int(Clock clock)
        {
            return clock.Hours;
        }
            
    }
}
