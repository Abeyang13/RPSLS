using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        // member variables (HAS A)
        private int numberOfPlayers;
        private Player player1;
        private Player player2;
        private int winningThreshold;
        // constructor
        public Game()
        {
            winningThreshold = 2;
        }


        // member methods (CAN DO)
        private void DisplayRules()
        {
            Console.WriteLine("Rules of the Game: \nEach player makes a gesture choice.\nPlayer with the winning gesture gets 1 point for that turn.(Gesture Comparison)*\nPlayer who gets to 2 wins.  Wins the Game\n");
            Console.WriteLine("Gesture Comparison:*\n Rock crushes Scissors\n Scissors cuts Paper\n Paper covers Rock\n Rock crushes Lizard\n Lizard poisons Spock\n Spock smashes Scissors\n Scissors decapitates Lizard\n Paper disproves Spock\n Spock vaporizes Rock");
        }
        private int GetNumberOfPlayers()
        {
          Console.WriteLine("How many players 1 or 2?");
          while(int.TryParse(Console.ReadLine(), out numberOfPlayers) && numberOfPlayers > 2 || numberOfPlayers < 1)
            {
                Console.WriteLine("Incorrect!! Please enter 1 or 2 you Flamingo");
            }
            return numberOfPlayers;
        }
        private void SettingUpPLayer(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new CPU();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void RunGame()
        {
            DisplayRules();
            int numberOfPlayers = GetNumberOfPlayers();
            SettingUpPLayer(numberOfPlayers);
            player1.ChooseName();
            player2.ChooseName();

            while (player1.winCounter < winningThreshold && player2.winCounter < winningThreshold)
            {

                player1.ChooseGesture();
                player2.ChooseGesture();
                GestureComparison();
                Console.WriteLine("Current score: " + player1.name + ": " + player1.winCounter + " - " + player2.name + ": " + player2.winCounter + "\n");
            }
            DisplayWinner();
        }

        private void GestureComparison()
        {
            if (player1.gesture == "rock")
            {
                if (player2.gesture == "scissors" || player2.gesture == "lizard")
                {
                    Console.WriteLine(player1.name + " beat " + player2.name);
                    player1.winCounter++;
                }
                else if (player2.gesture == "paper" || player2.gesture == "spock")
                {
                    Console.WriteLine(player2.name + " beat " + player1.name);
                    player2.winCounter++;
                }
                else
                {
                    Console.WriteLine("This was a Tie");
                }
            }

            else if (player1.gesture == "scissors")
            {
                if (player2.gesture == "paper" || player2.gesture == "lizard")
                {
                    Console.WriteLine(player1.name + " beat " + player2.name);
                    player1.winCounter++;
                }
                else if (player2.gesture == "rock" || player2.gesture == "spock")
                {
                    Console.WriteLine(player2.name + " beat " + player1.name);
                    player2.winCounter++;
                }
                else
                {
                    Console.WriteLine("This was a Tie");
                }
            }

            else if (player1.gesture == "paper")
            {
                if (player2.gesture == "rock" || player2.gesture == "spock")
                {
                    Console.WriteLine(player1.name + " beat " + player2.name);
                    player1.winCounter++;
                }
                else if (player2.gesture == "scissors" || player2.gesture == "lizard")
                {
                    Console.WriteLine(player2.name + " beat " + player1.name);
                    player2.winCounter++;
                }
                else
                {
                    Console.WriteLine("This was a Tie");
                }
            }

            else if (player1.gesture == "lizard")
            {
                if (player2.gesture == "paper" || player2.gesture == "spock")
                {
                    Console.WriteLine(player1.name + " beat " + player2.name);
                    player1.winCounter++;
                }
                else if (player2.gesture == "rock" || player2.gesture == "scissors")
                {
                    Console.WriteLine(player2.name + " beat " + player1.name);
                    player2.winCounter++;
                }
                else
                {
                    Console.WriteLine("This was a Tie");
                }
            }

            else if (player1.gesture == "spock")
            {
                if (player2.gesture == "rock" || player2.gesture == "scissors")
                {
                    Console.WriteLine(player1.name + " beat " + player2.name);
                    player1.winCounter++;
                }
                else if (player2.gesture == "paper" || player2.gesture == "lizard")
                {
                    Console.WriteLine(player2.name + " beat " + player1.name);
                    player2.winCounter++;
                }
                else
                {
                    Console.WriteLine("This was a Tie");
                }
            }
        }
        private void DisplayWinner()
        {
            if (player1.winCounter == winningThreshold)
            {
                Console.WriteLine(player1.name + " won the game!\n");
            }
            else
            {
                Console.WriteLine(player2.name + " won the game!\n");
            }
            Console.WriteLine("Game over!");
        }
    }
}
