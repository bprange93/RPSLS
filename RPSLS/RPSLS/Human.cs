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


        //constructor
        public Human() 
        {
           
        }

        //member methods
        public override void ChooseGesture()
        {
            //have user put their selection in for which they will choose
            Console.WriteLine("Which gesture would you like to use?");
            string[] gestures = { "rock", "paper", "scissors", "lizard", "spock" };
            string response = Console.ReadLine().ToLower();
            for (string rock)
            {
                if()
            }

        }
    }
}
