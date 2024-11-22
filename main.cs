using System;
using System.Collections.Generic;

namespace GameDev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Game Development!");
            Game game = new Game();
            game.Start();
        }
    }

    class Game
    {
        private Character player;
        private List<Character> opponents;
        private Leaderboard leaderboard;

        public Game()
        {
            player = new Character("Teknik Elektro");
            opponents = new List<Character>
            {
                new Character("Teknik Mesin"),
                new Character("Teknik Sipil"),
                new Character("Teknik Kimia")
            };
            leaderboard = new Leaderboard();
        }

        public void Start()
        {
            Console.WriteLine("Starting the game...");
            // Game logic here
        }
    }

    class Character
    {
        public string Department { get; private set; }
        public int Health { get; private set; }
        public int Energy { get; private set; }
        public int Points { get; private set; }

        public Character(string department)
        {
            Department = department;
            Health = 100;
            Energy = 100;
            Points = 0;
        }

        public void Battle(Character opponent)
        {
            // Battle logic here
        }

        public void Upgrade()
        {
            // Upgrade logic here
        }
    }

    class Leaderboard
    {
        private List<Character> rankings;

        public Leaderboard()
        {
            rankings = new List<Character>();
        }

        public void Update(Character character)
        {
            // Update leaderboard logic here
        }

        public void Display()
        {
            // Display leaderboard logic here
        }
    }
}