using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer

    {
        Random random = new Random();
        public int NextMove()
        {
            // 0:, Rock, 1: Paper: or 2: Scissors;
            return random.Next(0, 3); //max has to be higher than the value(2)
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //this method intentionally left blank.
        }
    }
}
