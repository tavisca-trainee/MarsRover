using System.Collections.Generic;

namespace MarsRover
{
    public class MoveInstruction: IInstruction
    {
        private static HashSet<char> AllowedMoves { get; } = new HashSet<char>
        {
            'M', 'F'
        };

        private static Dictionary<char, Step> _move { get; } = new Dictionary<char, Step>()
        {
            {'E', new Step() { X = 1, Y = 0} },
            {'S', new Step() { X = 0, Y = -1} },
            {'W', new Step() { X = -1, Y = 0} },
            {'N', new Step() { X = 0, Y = 1} }
        };

        public bool TryProcessing(char command, ref Rover rover)
        {
            if (IsAMove(command) == false)
            {
                return false;
            }

            Move(ref rover);
            return true;
        }

        private static bool IsAMove(char turn) => AllowedMoves.Contains(turn);

        public static void Move(ref Rover rover)
        {
            Step step = _move[rover.Compass.Direction];

            var newPosition = new Position()
            {
                X = rover.Position.X + step.X,
                Y = rover.Position.Y + step.Y
            };

            if (rover.Map.IsInVicinity(newPosition))
                rover.Position = newPosition;
        }
    }
}
