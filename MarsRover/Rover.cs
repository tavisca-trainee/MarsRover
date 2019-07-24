using System;

namespace MarsRover
{
    public class Rover
    {
        public Position Position { get; set; }

        public Compass Compass { get; set; }

        public InstructionProcessor InstructionProcessor { get; set; }

        public Rover(string initialState) //int x, int y, string direction
        {
            var tokens = initialState.Split(' ');
            this.Position = new Position { X = int.Parse(tokens[0]), Y = int.Parse(tokens[1]) };
            this.Compass = new Compass((Direction)Enum.Parse(typeof(Direction), tokens[2]));
            this.InstructionProcessor = new InstructionProcessor(this);
        }

        public void RecieveInstructions(string instructions)
        {
            this.InstructionProcessor.GetInstructions(instructions);
            this.InstructionProcessor.PerformProcessing(this);
        }
    }
}