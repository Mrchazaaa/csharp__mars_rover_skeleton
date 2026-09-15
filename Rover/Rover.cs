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

    public void ReceiveCommand(Command command)
    {
        switch (command)
        {
            case Command.F:
                switch (this.Direction)
                {
                    case Direction.North:
                        this.x = 1;
                        this.y = 2;
                        break;
                    case Direction.East:
                        this.x = 2;
                        this.y = 1;
                        break;
                    case Direction.South:
                        this.x = 1;
                        this.y = 0;
                        break;
                    case Direction.West:
                        this.x = 0;
                        this.y = 1;
                        break;
                }
                break;
            case Command.B:
                switch (this.Direction)
                {
                    case Direction.North:
                        this.x = 1;
                        this.y = 0;
                        break;
                    case Direction.East:
                        this.x = 0;
                        this.y = 1;
                        break;
                    case Direction.South:
                        this.x = 1;
                        this.y = 2;
                        break;
                    case Direction.West:
                        this.x = 2;
                        this.y = 1;
                        break;
                }
                break;
        }

    }
}
