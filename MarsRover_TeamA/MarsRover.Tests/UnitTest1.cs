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
    public void InitializingAtSpecifiedPosition()
    {
        Rover rover = new Rover(4, 7, RoverDirection.North);
        Assert.That(rover.PositionX, Is.EqualTo(4));
        Assert.That(rover.PositionY, Is.EqualTo(7));
        Assert.That(rover.Direction, Is.EqualTo(RoverDirection.North));
    }
}