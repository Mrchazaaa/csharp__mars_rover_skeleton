namespace WakingSkeleton;

public class Product : IProduct
{
    public int HeldCount;

    public Product()
    {
        HeldCount = 0;
    }

    public void Hold()
    {
        HeldCount++;
    }
}