using System;

namespace MarsRover.App
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMapCoordinates(out int mapEndX, out int mapEndY);

            GetRoverPositionAndDirection(out int rover1X, out int rover1Y, out char rover1Direction);
            GetCommand(out string rover1Command);

            GetRoverPositionAndDirection(out int rover2X, out int rover2Y, out char rover2Direction);
            GetCommand(out string rover2Command);

            var rover1 = new Rover()
            {
                Position = new Position() { X = rover1X, Y = rover1Y },
                Map = new Map()
                {
                    MinimumCoordinate = new Position { X = 0, Y = 0 },
                    MaximumCoordinate = new Position { X = mapEndX, Y = mapEndY }
                },
                Compass = new Compass() { Direction = rover1Direction }
            };

            var rover2 = new Rover()
            {
                Position = new Position() { X = rover2X, Y = rover2Y },
                Map = new Map()
                {
                    MinimumCoordinate = new Position { X = 0, Y = 0 },
                    MaximumCoordinate = new Position { X = mapEndX, Y = mapEndY }
                },
                Compass = new Compass() { Direction = rover2Direction }
            };

            rover1.Command(rover1Command);
            rover2.Command(rover2Command);

            Console.WriteLine($"{rover1.Position.X} {rover1.Position.Y} {rover1.Compass.Direction}");
            Console.WriteLine($"{rover2.Position.X} {rover2.Position.Y} {rover2.Compass.Direction}");

            Console.ReadLine();
        }

        static void GetMapCoordinates(out int x, out int y)
        {
            var coordinates = Console.ReadLine().Split(' ');
            x = int.Parse(coordinates[0]);
            y = int.Parse(coordinates[1]);
        }

        static void GetRoverPositionAndDirection(out int x, out int y, out char direction)
        {
            var info = Console.ReadLine().Split(' ');
            x = int.Parse(info[0]);
            y = int.Parse(info[1]);
            direction = info[2][0];
        }

        static void GetCommand(out string command)
        {
            command = Console.ReadLine();
        }
    }
}
