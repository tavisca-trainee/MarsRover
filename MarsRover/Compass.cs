using System;
using System.Collections.Generic;

namespace MarsRover
{
    public enum Directions
    {
        N, NE, E, SE, S, SW, W, NW
    }
    public class Compass
    {
        public Directions Direction { get; set; }
    }
}
