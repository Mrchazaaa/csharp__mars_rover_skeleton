namespace Rover;

public sealed class Rover
{
    public int x;
    public int y;
    public Direction Direction;

    public Rover(int x, int y, Direction direction)
    {
        this.x = x;
        this.y = y;
        this.Direction = direction;
    }

    public void ReceiveCommand()
    {
        this.y = 2;
    }
}
