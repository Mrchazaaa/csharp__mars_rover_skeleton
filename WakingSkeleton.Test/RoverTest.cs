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
    public void MovingRoverForwardMovesForwardByOne()
    {
        var rover = new Rover(1, 1, Direction.North);

        rover.ReceiveCommand();

        Assert.That(rover.x, Is.EqualTo(1));
        Assert.That(rover.y, Is.EqualTo(2));
    }
}
