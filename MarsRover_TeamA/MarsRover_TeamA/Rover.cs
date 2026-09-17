using System.Diagnostics;

namespace MarsRover_TeamA;

public class Rover
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public RoverDirection Direction { get; set; }

    public Rover(int positionX, int positionY, string direction)
    {
        PositionX = positionX;
        PositionY = positionY;
        Direction = convertDirection(direction);
    }

    public override string ToString()
    {
        return $"Rover is at {PositionX},{PositionY} facing {Direction}";
    }

    private RoverDirection convertDirection(string direction)
    {
        switch (direction)
        {
            case "N":
                return RoverDirection.North;
            case "E":
                return RoverDirection.East;
            case "W":
                return RoverDirection.West;
            case "S":
                return RoverDirection.South;
            default:
                throw new ArgumentException("not recognized");
        }
    }
}