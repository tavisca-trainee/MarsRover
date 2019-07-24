namespace MarsRover
{
    public interface IInstruction
    {
        bool TryProcessing(char instruction, ref Rover rover);
    }
}
