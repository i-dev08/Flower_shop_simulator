using System.Collections.Generic;

public class Order
{
    public Dictionary<ItemType, int> flowers;

    public string ribbon;
    public string wrapping;

    public Order()
    {
        flowers = new Dictionary<ItemType, int>();
        ribbon = "Not Selected";
        wrapping = "Not Selected";
    }
}
