using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Map
    {
        public CoOrdinates MaxCoOrdinate { get; set; }
        public CoOrdinates MinCoOrdinate => new CoOrdinates { X = 0, Y = 0 };

        public Map(int x, int y)
        {
            this.MaxCoOrdinate = new CoOrdinates { X = x, Y = y };
        }
    }
}
