using System;
using System.Collections.Generic;
using System.Text;

namespace Test.GitIgnore
{
    struct StructNumber
    {
        private int _num;
        public int num { get; set; }
        public void Info()
        {
            Console.WriteLine("\nThe stored value is: {0}\n", num);
        }
    }
}        
