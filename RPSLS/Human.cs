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
            Console.WriteLine("Choose A Gesture: Rock, Paper, Scissors, Lizard, or Spock");
            gesture = Console.ReadLine().ToLower();
        }
        public override void ChooseName()
        {
            Console.WriteLine("Choose a Name");
            name = Console.ReadLine();
        } 
    }
}
