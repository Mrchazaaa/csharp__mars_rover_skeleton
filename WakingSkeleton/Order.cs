namespace WakingSkeleton;

public interface IProduct;

public class Order
{
    public IEnumerable<IProduct> Items { get; set; }

    public Order()
    {
        Items = new List<IProduct>();
    }

    public void AddItem(IProduct item)
    {
        Items = Items.Append(item);
    }
}