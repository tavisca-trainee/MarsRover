using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class InstructionProcessor
    {
        private readonly List<IInstruction> _instructions = new List<IInstruction>()
        {
            new TurnInstruction(),
            new MoveInstruction()
        };

        internal void ProcessInstructionString(string instructions, Rover rover)
        {
            foreach (var command in instructions)
            {
                TryProcessingEachCommand(command, ref rover);
            }
        }

        private void TryProcessingEachCommand(char cmd, ref Rover rover)
        {
            foreach (var instruction in _instructions)
            {
                if (instruction.TryProcessing(cmd, ref rover) == true)
                    return;
            }
        }
    }
}
