using System;
using System.Collections.Generic;

namespace GameDev
{
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

        public void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. View Leaderboard");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Start();
                        break;
                    case "2":
                        leaderboard.Display();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the game. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}