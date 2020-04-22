using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input distance(meters): ");
            float distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            float hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            float min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            float sec = Convert.ToSingle(Console.ReadLine());
            float timeSec = (hour * 3600) + (min * 60) + sec;
            float mps = distance / timeSec;
            float kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            float mph = kph / 1.609f;

            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);

        }
    }
}

