﻿namespace MarsRover
{
    public class TurnInstruction: IInstruction
    {
        public char Direction { get; set; }

        public bool TryProcessing(char instruction, Rover rover)
        {
            throw new System.NotImplementedException();
        }
    }
}
