using System;

namespace MarsRover
{
    public class Rover
    {
        public Position Position { get; set; }

        public Compass Compass { get; set; }

        public Rover(int x, int y, Direction direction)
        {
            this.Position = new Position { X = x, Y = y };
            this.Compass = new Compass(direction);
        }
    }
}