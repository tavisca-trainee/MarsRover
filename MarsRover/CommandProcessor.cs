using System.Collections.Generic;

namespace MarsRover
{
    public class CommandProcessor
    {
        private readonly List<IInstruction> _instructions = new List<IInstruction>()
        {
            new TurnInstruction(),
            new MoveInstruction()
        };
    }
}
