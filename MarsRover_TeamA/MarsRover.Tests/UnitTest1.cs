using System.ComponentModel;
using MarsRover_TeamA;

namespace MarsRover.Tests;

public class MarsRoverTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(4, 7, "N", RoverDirection.North)]
    [TestCase(4, 7, "E", RoverDirection.East)]
    [TestCase(4, 7, "S", RoverDirection.South)]
    [TestCase(4, 7, "W", RoverDirection.West)]
    [TestCase(1, 4, "N", RoverDirection.North)]
    [TestCase(2, 3, "E", RoverDirection.East)]
    [TestCase(3, 2, "S", RoverDirection.South)]
    [TestCase(4, 1, "W", RoverDirection.West)]
    public void InitializingAtSpecifiedPosition(int x, int y, string inputDirection, RoverDirection expectedDirection)
    {
        Rover rover = new Rover(x, y, inputDirection);
        Assert.That(rover.PositionX, Is.EqualTo(x));
        Assert.That(rover.PositionY, Is.EqualTo(y));
        Assert.That(rover.Direction, Is.EqualTo(expectedDirection));
    }
}