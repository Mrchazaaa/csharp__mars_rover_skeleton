using Moq;

namespace WakingSkeleton.Test;

public class ProductTest
{

    [Test]
    public void HoldingProductHoldsStock()
    {
        var product = new Product(100, "test", 10, 0);

        product.Hold();

        Assert.That(product.HeldCount, Is.EqualTo(1));
    }
}