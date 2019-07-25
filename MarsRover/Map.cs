namespace MarsRover
{
    public class Map
    {
        public Position MinimumCoordinate { get; set; }
        public Position MaximumCoordinate { get; set; }

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
            if (MinimumCoordinate.X <= X && X <= MaximumCoordinate.X)
                return true;

            return false;
        }

        private bool YInRange(int Y)
        {
            if (MinimumCoordinate.Y <= Y && Y <= MaximumCoordinate.Y)
                return true;
            
            return false;
        }
    }
}