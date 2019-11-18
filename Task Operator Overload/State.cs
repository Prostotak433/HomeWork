using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Operator_Overload
{
    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }
        public static State operator +(State s1, State s2)
        {
            return new State
            {
                Population = s1.Population + s2.Population,
                Area = s1.Area + s2.Area
            };
        }
        public static bool operator >(State s1, State s2)
        {
            return s1.Area > s2.Area;
        }
        public static bool operator <(State s1, State s2)
        {
            return s1.Area < s2.Area;
        }
    }
}
