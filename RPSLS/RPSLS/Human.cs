using System;
using System.Collections.Generic;

namespace RPSLS
{
    class Human : Player
    {

        //member variables
       

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
            string gesture = Console.ReadLine().ToLower();
            if(validateChoice(gesture, gesturesList))
            {
                return gesture;
            }


        }

        public bool validateChoice(string userInput, List<string> gestureList)
        {
            foreach(string gesture in gestureList)
            {
                if (userInput.Equals(gesture))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
