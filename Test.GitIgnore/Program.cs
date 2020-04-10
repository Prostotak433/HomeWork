using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            SructNumber sructNumber = new SructNumber();
            sructNumber.Info();
            SructNumber sructNumber1 = new SructNumber(25, 25);
            sructNumber1.Info();
        }
    }
}
