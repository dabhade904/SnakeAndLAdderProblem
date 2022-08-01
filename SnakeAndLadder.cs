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
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;
        public const int WINING_POSITION = 100;
        //Variable
        public int playerPosition;
        public int counter = 0;
        public  int PlayGame(int player)
        {
            playerPosition = player;
            while (playerPosition < WINING_POSITION)
            {
                Random obj = new Random();
                int diceRoll = obj.Next(1, 7);
                int option = obj.Next(1, 3);
                switch (option)
                {
                    case LADDER:
                        playerPosition += diceRoll;
                        break;
                    case SNAKE:
                        playerPosition -= diceRoll;
                        break;
                    case NO_PLAY:
                        Console.WriteLine("No Play ");
                        break;
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                }
                else if (playerPosition > WINING_POSITION)
                {
                    playerPosition -= diceRoll;
                    Console.WriteLine("Stay in some previous position " + playerPosition);
                }
                counter++;
                Console.WriteLine(" counter and position  " + playerPosition);
            }
            return playerPosition;          
        }
        public  void initialPlay()
        {
            int playerA = 0;
            int playerB = 0;
            while (playerA != 100 && playerB != 100)
            {
                if (playerA == WINING_POSITION)
                {
                    Console.WriteLine("Player A is Winner");
                    break;
                }
                else if (playerB == WINING_POSITION)
                {
                    Console.WriteLine("Player b is Winner");
                    break;
                }
                else
                {
                    playerA = PlayGame(playerA);
                    //   playerA += resA;
                    playerB = PlayGame(playerB);
                 //   playerB += resB;
                }
            }
        }
    }
}
