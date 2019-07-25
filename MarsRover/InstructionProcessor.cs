using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class InstructionProcessor
    {
        public List<Instruction> Instructions { get; set; }

        //sir ka emthod to remove if else id to create a lsit of fucntions to be accessed after the condition checking.
        //then add tryparse.

        public InstructionProcessor(Rover rover)
        {
            this.Instructions = new List<Instruction>();
        }

        public void GetInstructions(string instructions)
        {
            for (int i = 0; i < instructions.Length; i++)
            {
                Instructions.Add((Instruction)Enum.Parse(typeof(Instruction), instructions[i].ToString()));
            }
        }

        public void PerformProcessing(Rover rover)
        {
            foreach (var instruction in Instructions)
            {
                if (instruction == Instruction.L || instruction == Instruction.R)
                {
                    rover.Compass.ChangeDirection(rover, instruction);
                }

                if (instruction == Instruction.M)
                {
                    rover.Move();
                }
            }
        }
    }
}