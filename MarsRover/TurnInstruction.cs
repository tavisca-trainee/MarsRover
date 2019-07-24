using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class TurnInstruction
    {
        public char Direction { get; set; }

        public TurnInstruction(char turn)
        {
            this.Direction = turn;
        }
    }
}
