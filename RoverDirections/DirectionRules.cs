using System;

namespace RoverDirections
{
    public class DirectionRules
    {
        public Coordinates GetCoordinates(Coordinates coordinates, char command)
        {
            switch (coordinates.direction)
            {
                case Direction.North:
                    if (command.Equals('L')) return new Coordinates(coordinates.X,coordinates.Y, Direction.West);
                    if (command.Equals('R')) return new Coordinates(coordinates.X, coordinates.Y, Direction.East);
                    else throw new FormatException();
                case Direction.South:
                    if (command.Equals('L')) return new Coordinates(coordinates.X, coordinates.Y, Direction.East);
                    if (command.Equals('R')) return new Coordinates(coordinates.X, coordinates.Y, Direction.West);
                    else throw new FormatException();
                case Direction.West:
                    if (command.Equals('L')) return new Coordinates(coordinates.X, coordinates.Y, Direction.South);
                    if (command.Equals('R')) return new Coordinates(coordinates.X, coordinates.Y, Direction.North);
                    else throw new FormatException();
                case Direction.East:
                    if (command.Equals('L')) return new Coordinates(coordinates.X, coordinates.Y, Direction.North);
                    if (command.Equals('R')) return new Coordinates(coordinates.X, coordinates.Y, Direction.South);
                    else throw new FormatException();
                default:
                    throw new FormatException();
            }
        }
    }
}
