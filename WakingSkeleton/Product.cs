namespace WakingSkeleton;

public class Product : IProduct
{
    public Product(int productId, string productName, int stock, int hold)
    {
        this.HeldCount = hold;
        this.Stock = stock;
        this.ProductId = productId;
        this.ProductName = productName;
    }
    public int HeldCount { get; private set;  }

    public string ProductName { get; }

    public int ProductId { get; }

    public int Stock { get; }

    public void Hold()
    {
        HeldCount++;
    }
}