using System;

namespace _3_Task_Overloading_Type_Conversion_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar1 = new Dollar { Sum = 100 };
            Euro euro = dollar1;
            Console.WriteLine(euro.Sum);
            

        }
    }
    class Dollar
    {
        public decimal Sum { get; set; }

    }
    class Euro
    {
        public decimal Sum { get; set; }
        public static implicit operator Euro(Dollar dollar)
        {
            return new Euro { Sum = dollar.Sum / 1.14M };
        }
        public static explicit operator Dollar(Euro euro)
        {
            return new Dollar { Sum = euro.Sum * 1.14M };
        }
    }
}
