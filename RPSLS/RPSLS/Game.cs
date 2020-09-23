using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        //member variables
        Player playerOne;
        Player playerTwo;
        int scoreTowWin = 2;

        //constructor
        public Game()
        {
           

            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
        }

        //member methods

       public void RunGame()
        {
            //Intro Section
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            //Greeting

            //rules
            Console.WriteLine("Pay attention carefully for here are the rules on how to defeat your opponent. ");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Scissors cuts paper");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");            
            Console.ReadLine();

            //Choose game tpye - PvP or PvAI
            pickNumberofPlayers();

            //Gameplay Rounds Section
            Console.WriteLine("Game will be best 2/3.");
            Console.ReadLine();

            //Display current state of game points
            //Display gesture options
            //Player One Chooses a gesture
            //Display gesture options
            //Player Two Chooses a gesture IF chosen
            //compare gestures to see who wins to award point for round
            //display outcome of the round
            //utiliza a check on points to see if we need another round



            //EndGame
            //Display Winner of game
            // optionally prompt for a new game

        }
        public void pickNumberofPlayers()
        {
            Console.WriteLine("Would you like to face another player or the computer?");
            string response = Console.ReadLine();
            switch (response)
            {
                case "player":
                    playerOne = new Human();
                    playerTwo = new Human();
                    break;
                case "computer":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    break;
            }
        }
    }
}
