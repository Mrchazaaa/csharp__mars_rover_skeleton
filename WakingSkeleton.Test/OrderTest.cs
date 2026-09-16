using Moq;

namespace WakingSkeleton.Test;

public class OrderTest
{

    [Test]
    public void AddingItemToOrderAddsItemToOrder()
    {
        var order = new Order();
        order.AddItem(new Mock<IProduct>().Object);
        Assert.That(order.Items.Count(), Is.EqualTo(1));
    }
}