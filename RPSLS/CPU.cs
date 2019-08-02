using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class CPU : Player
    {
        //members variable (Has A)
        



        //constructor 



        //methods (To Do)
        public override void ChooseGesture()
        {
            Random random = new Random();
            List<string> Gestures = new List<string>() { "rock", "scissors", "paper", "lizard", "spock" };
            int generateChoice = random.Next(Gestures.Count);
            gesture = Gestures[generateChoice];
            Console.WriteLine($"{name} chose: " + gesture);
        }
        public override void ChooseName()
        {
            Console.WriteLine("Choose a Name for CPU");
            name = Console.ReadLine();

        }
    }
}
