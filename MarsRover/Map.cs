namespace MarsRover
{
    public class Map
    {
        public Position StartPosition { get; set; }
        public Position EndPosition { get; set; }

        public bool IsInVicinity(Position position)
        {
            if (XInRange(position.X) == false)
                return false;

            if (YInRange(position.Y) == false)
                return false;
            
            return true;
        }

        private bool XInRange(int X)
        {
            if (StartPosition.X <= X && X <= EndPosition.X)
                return true;

            return false;
        }

        private bool YInRange(int Y)
        {
            if (StartPosition.Y <= Y && Y <= EndPosition.Y)
                return true;
            
            return false;
        }
    }
}