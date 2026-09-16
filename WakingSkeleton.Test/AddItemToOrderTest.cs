using Moq;

namespace WakingSkeleton.Test;

public class AddItemToOrderTest
{

    [Test]
    public void AddingItemToOrderAddsItemToOrder()
    {
        var order = new Order();
        order.AddItem(new Mock<IProduct>().Object);
        Assert.That(order.Items.Count(), Is.EqualTo(1));
    }

    [Test]
    public void AddingItemToOrderSetsHoldOnProduct()
    {
        var product = new Product(327, "Ibanez Tube Screamer", 7, 0);
        var order = new Order();
        order.AddItem(product);
        Assert.That(product.HeldCount, Is.EqualTo(1));
    }
}