using System;

namespace _3._1_Task_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Team dnepr = new Team();
            dnepr[0] = new Player { Name = "Tom", Number = 13 };
        }
    }
    class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    class Team
    {
        Player[] players = new Player[11];
        public Player this[int index]
        {
            get { return players[index]; }
            set { players[index] = value; }
        }
    }
}
