﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        // member variables (HAS A)
        public Player player1;
        public Player player2;
        public int winningThreshold;
        // constructor
        public Game()
        {
            winningThreshold = 2;
        }


        // member methods (CAN DO)
        private void DisplayRules()
        {
            Console.WriteLine("Rules Of Game:\n Rock crushes Scissors\n Scissors cuts Paper\n Paper covers Rock\n Rock crushes Lizard\n Lizard poisons Spock\n Spock smashes Scissors\n Scissors decapitates Lizard\n Paper disproves Spock\n Spock vaporizes Rock");
        }
        private int GetNumberOfPlayers()
        {
            try
            {
                Console.WriteLine("How many players 1 or 2?");
                int numberOfPlayers = int.Parse(Console.ReadLine());
                if (numberOfPlayers == 1 || numberOfPlayers == 2)
                {
                    return numberOfPlayers;
                }
                else
                {
                    return GetNumberOfPlayers();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter 1 or 2");
                return GetNumberOfPlayers();
            }
            
            
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

                else 
                {
                    Console.WriteLine("Please choose a correct gesture");
                }
                Console.WriteLine("Current score: " + player1.name + ": " + player1.winCounter + " - " + player2.name + ": " + player2.winCounter + "\n");
            }
            DisplayWinner();
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
