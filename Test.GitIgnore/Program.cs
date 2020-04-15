using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value for X coordinate : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input the value for Y coordinate : ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the 1 quadrant.", x, y);
            else if (x > 0 && y < 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the 2 quadrant.", x, y);
            else if (x < 0 && y > 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the 3 quadrant.", x, y);
            else if (x < 0 && y < 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the 4 quadrant.", x, y);

        }
    }
}
