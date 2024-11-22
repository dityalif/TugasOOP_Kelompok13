using System;

namespace GameDev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Game Development!");
            Game game = new Game();
            game.ShowMainMenu();
        }
    }
}