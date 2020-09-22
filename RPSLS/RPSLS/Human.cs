using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        //member variables
        public bool computer;
        public int roundsWon;

        //constructor
        public Human() 
        {
            computer = false;
        }

        //member methods
        public override void ChooseGesture()
        {
            //have user put their selection in for which they will choose
            Console.WriteLine("Which gesture would you like to use?");
            Console.WriteLine("Gestures are Rock, Paper, Scissors, Lizard, and Spock.");
            string response = Console.ReadLine().ToLower();
            if(response == gestures[0])
            {
                Console.WriteLine("rock");
            }
            if(response == gestures[1])
            {
                Console.WriteLine("paper");

            }
            if (response == gestures[2])
            {
                Console.WriteLine("scissors");

            }
            if (response == gestures[3])
            {
                Console.WriteLine("lizard");

            }
            if (response == gestures[4])
            {
                Console.WriteLine("spock");

            }
        }
    }
}
