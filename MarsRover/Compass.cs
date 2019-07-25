using System;
using System.Collections.Generic;

namespace MarsRover
{
    public enum Directions
    {
        N, E, S, W
    }
    public class Compass
    {
        public Directions Direction { get; set; }
    }
}
