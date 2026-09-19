using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    private Dictionary<ItemType, int> items = new Dictionary<ItemType, int>();

    private string ribbon ="Not Selected";
    public void AddFlowerFinal(ItemType itemType, int amount = 1)
    {
        if(items.ContainsKey(itemType))
        {
            items[itemType] += amount;
        }
        else
        {
            items[itemType] = amount;
        }

         Debug.Log(
            "Added " + amount + " " + itemType +
            " | Total: " + items[itemType]
        );
    }
    
    public int GetItemCount(ItemType itemType)
    {
        if(items.ContainsKey(itemType))
        {
            return items[itemType];
        }
        return 0;
    }

    public void AddRibbon(string color)
    {
        ribbon = color;
    }

    public string GetRibbon()
    {
        return ribbon;
    }
}
