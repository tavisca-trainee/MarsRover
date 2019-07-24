using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Compass
    {
        public Direction Direction { get; set; }

        public Compass(Direction direction)
        {
            this.Direction = direction;
        }

        public void ChangeDirection(Rover rover, Instruction instruction)
        {
            var direction = (int)Direction;

            if(instruction == Instruction.L)
            {
                direction = (direction - 1) % 4 > 0 ? (direction - 1) % 4 : 4;
                this.Direction = (Direction)direction;
            }

            if(instruction == Instruction.R)
            {
                direction = (direction + 1) % 4;
                this.Direction = (Direction)direction;
            }
        }
    }
}