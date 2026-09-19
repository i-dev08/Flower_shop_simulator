using UnityEngine;

public class OrderManager : MonoBehaviour
{
   
   public Order currentOrder;

   public void GenerateOrder()
    {
        currentOrder = new Order();

        GenerateFlowers();
        GenerateRibbon();
        GenerateWrapping();
    }

    void GenerateFlowers()
    {
        ItemType[] flowers =
        {
            ItemType.Rose,
            ItemType.Tulip,
            ItemType.Sunflower
        };

        bool hasFlower = false;
        
        foreach (ItemType flower in flowers)
        {
            int amount = Random.Range(0,4);

            if (amount>0)
            {
                currentOrder.flowers.Add(flower,amount);
                hasFlower = true;
            }
        }

        if (!hasFlower)
        {
            ItemType randomFlower = flowers[Random.Range(0,flowers.Length)];

            currentOrder.flowers.Add(randomFlower,1);
        }
    }

    void GenerateRibbon()
    {
        string[] ribbons =
        {
            "Red",
            "Blue",
            "Yellow"
        };

        currentOrder.ribbon = ribbons[Random.Range(0,ribbons.Length)];
    }

    void GenerateWrapping()
    {
        string[] wrappings =
        {
            "Red",
            "Blue",
            "Yellow",
            "Green"
        };

        currentOrder.wrapping = wrappings[Random.Range(0,wrappings.Length)];
    }
}
