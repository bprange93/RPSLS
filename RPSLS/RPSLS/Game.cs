using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        //member variables
        Player playerOne;
        Player playerTwo;

        //constructor
        public Game()
        {
            playerOne = new Human();
        }

        //member methods

        public void ChooseGameMode()
        {
            Console.WriteLine("Do you want 1 player or 2 players? Type '1' or '2':");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    playerTwo = new AI();
                    break;
                case "2":
                    playerTwo = new Human();
                    break;
                default:
                    break;
            }
        }
    }
}
