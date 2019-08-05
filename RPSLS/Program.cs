using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Game game = new Game();
            game.RunGame();
        }
    }
}
