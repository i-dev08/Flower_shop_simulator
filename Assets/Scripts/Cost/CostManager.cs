using System.Collections.Generic;
using UnityEngine;

public class CostManager : MonoBehaviour
{
    public OrderManager orderManager;

    public int CostCalc()
    {
        if (orderManager.currentOrder == null) return 0;

        int cost = 0;
        Order order = orderManager.currentOrder;

        foreach (var flower in order.flowers)
        {
            cost += FlowerCostcalc(flower.Key, flower.Value);
        }
        cost += RibbonCost(order.ribbon) + WrappingCost(order.wrapping);

        return cost;
        
    }
   int FlowerCostcalc(ItemType flower, int amount)
    {
        switch(flower)
        {
            case ItemType.Rose:
                return amount*10;

            case ItemType.Tulip:
                return amount*5;

            case ItemType.Sunflower:
                return amount*6;

            default: return 0;
        }
    }

    int RibbonCost(string color)
    {
        switch(color)
        {
            case "Red":
                return 5;
            case "Blue":
                return 7;
            case "Yellow":
                return 3;
            default: return 0;
        }
    }

    int WrappingCost(string color)
    {
        switch (color)
        {
            case "Red":
                return 20;
            case "Blue":
                return 15;
            case "Green":
                return 25;
            case "Yellow":
                return 20;
            default: return 0;
        }
    }
}
