using System;


namespace Test.GitIgnore
{
    struct SructNumber
    {
        public int n;
        public int m;
        public SructNumber(int n1, int m1)
        {
            n = n1;
            m = m1;
        }
        public void Info()
        {
            Console.WriteLine("m = {0}, n = {1}", m,n);
        }
    }
}        
