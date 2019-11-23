using System;

namespace _3._1_Task_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Instantiator<T>
    {
        public T instance;
        public Instantiator()
        {
            instance = default (T);
        }
    }
}
