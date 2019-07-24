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

        public bool TryProcessing(char cmd, Rover rover)
        {
            foreach (var instruction in _instructions)
            {
                if (instruction.TryProcessing(cmd, rover) == true)
                    return true;
            }

            return false;
        }
    }
}
