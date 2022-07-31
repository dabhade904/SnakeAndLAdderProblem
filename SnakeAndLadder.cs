using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeAndLadder
    {
        //Constant for a program
        public const int LADDER= 1;
        public const int SNAKE =2;
        public const int NO_PLAY = 0;
        public const int WINING_POSITION = 100;
        //Variable
        int playerPosition = 0;
        public void PlayGame()
        {
            while(playerPosition< WINING_POSITION)
            {
                Random obj = new Random();
                int dieRoll = obj.Next(1, 7);
                int option = obj.Next(0, 3);
                switch (option)
                {
                    case LADDER:
                        playerPosition += dieRoll;
                        break;
                    case SNAKE:
                        playerPosition -= dieRoll;
                        break;
                    case NO_PLAY:
                        Console.WriteLine("No Play");
                        break;      
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                }
                else if (playerPosition >WINING_POSITION)
                {
                    playerPosition -= dieRoll;
                    Console.WriteLine("Stay in some previous position" + playerPosition);
                }
            }
        }
    }
}
