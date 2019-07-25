using System;

namespace MarsRover
{
    public class Rover
    {
        public Position Position { get; set; }
        public Compass Compass { get; set; }
        public Map Map { get; set; } 
        public InstructionProcessor InstructionProcessor;

        public Rover()
        {
            InstructionProcessor = new InstructionProcessor();
        }

        public void Command(string instructions)
        {
            InstructionProcessor.ProcessInstructionString(instructions, this);
        }

        public void SetMap(int x, int y)
        {
            Map = new Map
            {
                MinimumCoordinate = new Position() { X = 0, Y = 0 },
                MaximumCoordinate = new Position() { X = x, Y = y }
            };
        }

        public void SetDirection(char direction)
        {
            Compass = new Compass
            {
                Direction = direction
            };
        }

        public void SetPosition(int x, int y)
        {
            Position = new Position
            {
                X = x,
                Y = y
            };
        }

        public char GetDirection()
        {
            return Compass.Direction;
        }
    }
}
