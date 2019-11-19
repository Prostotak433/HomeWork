using System;

namespace _3._2__Task_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Team dnepr = new Team();
            dnepr[20] = new Player { Name = "Ronaldo", Number = 9 };
            dnepr[3] = new Player { Name = "lexa", Number = 13 };
            Console.WriteLine(dnepr[20]?.Name);
            Console.WriteLine(dnepr[3]?.Name);
        }
    }
    class Player
    {
        public string Name { get; set; } // имя
        public int Number { get; set; } // номер
    }
    class Team
    {
        Player[] players = new Player[11];

        public Player this[int index]
        {
            get
            {
                if (index >= 0 && index < players.Length)
                    return players[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < players.Length)
                    players[index] = value;
            }
        }
    }
}
