using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Gesture
    {
        // member variables (HAS A)
        List<string> Gestures = new List<string>{"Rock","Scissors","Paper","Lizard","Spock"};
        public Random rng;

        // constructor
        public Gesture()
        {
            GestureChoice(int winner, int loser);
            rng = new Random();
        }

        // member methods (CAN DO)
        public int GenerateNumber()
        {
            int generatedNumber = rng.Next(1, Gestures + 1);
            return generatedNumber;
        }

        public string GestureChoice(string winner, string loser)
        {
            string Gestures = "defeats";
                if ((winner == "Rock") && (loser =="Scissors"))
                {
                    Gestures = "crushes";
                }
                else if ((winner == "Scissors") && (loser == "Paper"))
                {
                    Gestures = "cuts";
                }
                else if ((winner == "Paper") && (loser == "Rock"))
                {
                    Gestures = "covers";
                }
                else if ((winner == "Rock") && (loser == "Lizard"))
                {
                    Gestures = "crushes";
                }
                else if ((winner == "Lizard") && (loser == "Spock"))
                {
                    Gestures = "poisons";
                }
                else if ((winner == "Spock") && (loser == "Scissors"))
                {
                    Gestures = "smashes";
                }
                else if ((winner == "Scissors") && (loser == "Lizard"))
                {
                    Gestures = "decapitates";
                }
                else if ((winner == "Lizard") && (loser == "Paper"))
                {
                    Gestures = "eats";
                }
                else if ((winner == "Paper") && (loser == "Spock"))
                {
                    Gestures = "disproves";
                }
                else if ((winner == "Spock") && (loser == "Rock"))
                {
                    Gestures = "vaporizes";
                }
                return Gestures;
            }
    }
}
