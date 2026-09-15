namespace WakingSkeleton.Test;

using Rover;

public class Tests
{
    [Test]
    public void InitializingRoverSetsPosition()
    {
        var x = 2;
        var y = 3;
        var direction = Direction.North;

        var rover = new Rover(
            x,
            y,
            direction);

        Assert.That(rover.x, Is.EqualTo(x));
        Assert.That(rover.y, Is.EqualTo(y));
        Assert.That(rover.Direction, Is.EqualTo(direction));
    }

    [Test]
    [TestCase(Command.F, Direction.North, 1, 2)]
    [TestCase(Command.F, Direction.East, 2, 1)]
    [TestCase(Command.F, Direction.South, 1, 0)]
    [TestCase(Command.F, Direction.West, 0, 1)]
    [TestCase(Command.B, Direction.North, 1, 0)]
    [TestCase(Command.B, Direction.East, 0, 1)]
    [TestCase(Command.B, Direction.South, 1, 2)]
    [TestCase(Command.B, Direction.West, 2, 1)]
    public void MovingRoverMovesByOne(Command command, Direction startingDirection, int expectedX, int expectedY)
    {
        var rover = new Rover(1, 1, startingDirection);

        rover.ReceiveCommand(command);

        Assert.That(rover.x, Is.EqualTo(expectedX));
        Assert.That(rover.y, Is.EqualTo(expectedY));
    }

    [Test]
    [TestCase(Command.L, Direction.North, Direction.West)]
    [TestCase(Command.L, Direction.East, Direction.North)]
    [TestCase(Command.L, Direction.South, Direction.East)]
    [TestCase(Command.L, Direction.West, Direction.South)]
    public void RotatingRover(Command command, Direction startingDirection, Direction targetDirection)
    {
        var rover = new Rover(1, 1, startingDirection);

        rover.ReceiveCommand(command);

        Assert.That(rover.Direction, Is.EqualTo(targetDirection));
    }
}
