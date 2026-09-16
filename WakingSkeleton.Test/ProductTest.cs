using Moq;

namespace WakingSkeleton.Test;

public class ProductTest
{

    [Test]
    public void HoldingProductHoldsStock()
    {
        var product = new Product();

        product.Hold();

        Assert.That(product.HeldCount, Is.EqualTo(1));
    }
}