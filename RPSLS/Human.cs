using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {
        //member variable

        //contructor




        //methods
        public override void ChooseGesture()
        {
            bool isValid = false;
            Console.WriteLine($"{name} Choose A Gesture: Rock, Paper, Scissors, Lizard, or Spock");
            string userInput = Console.ReadLine().ToLower();
            while (!isValid)
            {
                if (userInput == "rock" || userInput == "paper" || userInput == "scissors" || userInput == "lizard" || userInput == "spock")
                {
                    gesture = userInput;
                   
                }
                else
                {
                    ChooseGesture();
                }
                isValid = true;
            }
        }
        public override void ChooseName()
        {
            Console.WriteLine("Choose a Name");
            name = Console.ReadLine();
        } 
    }
}
