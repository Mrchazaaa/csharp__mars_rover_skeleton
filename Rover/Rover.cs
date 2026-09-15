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
            case Command.L:
                var newDirection = this.Direction - 1;
                
                if ((int)newDirection == -1)
                {
                    newDirection = Direction.West;
                }

                this.Direction = newDirection;
                break;
            case Command.F:
                switch (this.Direction)
                {
                    case Direction.North:
                        this.y = 2;
                        break;
                    case Direction.East:
                        this.x = 2;
                        break;
                    case Direction.South:
                        this.y = 0;
                        break;
                    case Direction.West:
                        this.x = 0;
                        break;
                }
                break;
            case Command.B:
                switch (this.Direction)
                {
                    case Direction.North:
                        this.y = 0;
                        break;
                    case Direction.East:
                        this.x = 0;
                        break;
                    case Direction.South:
                        this.y = 2;
                        break;
                    case Direction.West:
                        this.x = 2;
                        break;
                }
                break;
        }

    }
}
