using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {

        //member variables
        public int score;
        public List<string> gestures;
        public string chosenGesture;

        //constructor
        public Player()
        {
            score = 0;
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "Spock" };

        }

        //member methods
        public abstract void ChooseGesture();

    }
}
