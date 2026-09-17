namespace MarsRover_TeamA;

public class Rover
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }
    public RoverDirection Direction { get; set; }

    public Rover(int positionX, int positionY, RoverDirection direction)
    {
        PositionX = positionX;
        PositionY = positionY;
        Direction = direction;
    }
}