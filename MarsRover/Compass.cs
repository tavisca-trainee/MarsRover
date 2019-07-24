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
    }
}