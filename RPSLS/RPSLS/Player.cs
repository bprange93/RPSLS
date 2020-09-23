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
        public bool computer;
        public int score;
        public int roundsWon;
        public List<string> gesturesList = new List<string>() { "rock", "paper", "scissors", "lizard", "Spock" };
        public string gesture;

        //constructor
        public Player()
        {
            score = 0;
            roundsWon = 0;

        }

        //member methods
        public abstract void ChooseGesture();

    }
}
