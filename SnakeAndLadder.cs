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
        public void PlayGame()
        {
            int playerPosition = 0;
            Random obj=new Random();
            int diceRoll = obj.Next(1, 7);
            int option = obj.Next(0, 3);

            if(option == LADDER)
            {
                playerPosition += diceRoll;
                Console.WriteLine("Ladder Position is : " + diceRoll);
            }
            else if(option == SNAKE)
            {
                playerPosition = playerPosition - diceRoll;
                Console.WriteLine("Ladder Position decrease by " + playerPosition);
            }
            else
            {
                Console.WriteLine("No Play");
            }            
        }
    }
}
