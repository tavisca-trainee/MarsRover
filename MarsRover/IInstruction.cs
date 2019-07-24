using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public interface IInstruction
    {
        bool TryParse(char Instruction);
    }
}
