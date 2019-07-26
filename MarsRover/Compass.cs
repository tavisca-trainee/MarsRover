using System;
using System.Collections.Generic;

namespace MarsRover
{
    public enum Directions
    {
        North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest
    }
    public class Compass
    {
        public Directions Direction { get; set; }
    }
}
