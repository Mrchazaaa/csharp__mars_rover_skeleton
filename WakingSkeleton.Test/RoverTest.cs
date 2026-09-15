namespace WakingSkeleton.Test;

public class Tests
{
    public class Rover {
        public int x;
        public int y;
        public string direction;

        public Rover(int x, int y, string direction) {
          this.x = x;
          this.y = y;
          this.direction = direction;
        }
    }


    [Test]
    public void InitializingRoverSetsPosition()
    {
        var x = 2;
        var y = 3;
        var direction = "North";

        var rover = new Rover(
            x,
            y,
            direction);

        Assert.That(rover.x, Is.EqualTo(x));
        Assert.That(rover.y, Is.EqualTo(y));
        Assert.That(rover.direction, Is.EqualTo(direction));
    }
}