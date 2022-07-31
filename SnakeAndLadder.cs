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
        public void PlayGame()
        {
            for(int i=1;i<=WINING_POSITION;i++)
            {
                int playerPosition = 0;
                Random obj = new Random();
                int diceRoll = obj.Next(1, 7);
                int option = obj.Next(0, 3);
                switch (option)
                {
                    case LADDER:
                        playerPosition += diceRoll;
                        break;
                    case SNAKE:
                        playerPosition -= diceRoll;
                        break;
                    default:
                        Console.WriteLine("No Play");
                        break;      
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                    Console.WriteLine("Final player position"+playerPosition);
                }
            }
        }
    }
}
