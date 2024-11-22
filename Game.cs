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
            opponents = new List<Character>
            {
                new Character("Teknik Mesin", "Opponent1"),
                new Character("Teknik Sipil", "Opponent2"),
                new Character("Teknik Kimia", "Opponent3")
            };
            leaderboard = new Leaderboard();
        }

        public void Start()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            player = new Character("Teknik Elektro", username ?? "Player");

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