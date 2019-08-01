using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        // member variables (HAS A)
        public Player player1;
        public Player player2;
        public Player computer;
        public int winningThreshold;

        // constructor
        public Game()
        {
            player1 = new Player(1);
            player2 = new Player(2);
            computer = new Player(CPU);
            winningThreshold = 2;
        }


        // member methods (CAN DO)
        private void DisplayRules()
        {
            Console.WriteLine("Here are the rules!\n");
        }
        private void SelectMode()
        {
            Console.WriteLine("Please select Player vs Player or Player vs CPU");

        }
    }
}
