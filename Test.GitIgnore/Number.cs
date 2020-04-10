using System;
using System.Collections.Generic;
using System.Text;

namespace Test.GitIgnore
{
    struct StructNumber
    {
        public int n;
    }
    class ClassNumber
    {
        public int n;
    }
    class Methodd
    {
        public static void ClassMethod(ClassNumber n1)
        {
            n1.n = 9;
        }
        public static void StructMethod(StructNumber n1)
        {
            n1.n = 10;
        }
    }
}        
