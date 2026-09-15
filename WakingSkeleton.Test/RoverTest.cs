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
    [TestCase(Direction.North, 1, 2, Command.F)]
    [TestCase(Direction.East, 2, 1, Command.F)]
    [TestCase(Direction.South, 1, 0, Command.F)]
    [TestCase(Direction.West, 0, 1, Command.F)]
    [TestCase(Direction.North, 1, 0, Command.B)]
    [TestCase(Direction.East, 0, 1, Command.B)]
    [TestCase(Direction.South, 1, 2, Command.B)]
    [TestCase(Direction.West, 2, 1, Command.B)]
    public void MovingRoverForwardMovesByOne(Direction startingDirection, int expectedX, int expectedY, Command command)
    {
        var rover = new Rover(1, 1, startingDirection);

        rover.ReceiveCommand(command);

        Assert.That(rover.x, Is.EqualTo(expectedX));
        Assert.That(rover.y, Is.EqualTo(expectedY));
    }
}
