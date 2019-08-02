using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player
    {
        // member variables (HAS A)
        public string gesture;
        public string name;
        public int winCounter;
        

        // constructor
        public Player()
        {
            winCounter = 0;
        }
        // member methods (CAN DO)
        public abstract void ChooseGesture();
        public abstract void ChooseName();
       
    }
}
