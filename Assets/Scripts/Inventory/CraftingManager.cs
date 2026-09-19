using UnityEngine;

public class CraftingManager : MonoBehaviour
{
    public InventoryManager inventory;
    public OrderManager orderManager;

    public bool ValidateBouquet(string selectedWrapping)
    {
        if (orderManager.currentOrder == null)
        {
            Debug.Log("There is no current order");
            return false;
        }
        Order order = orderManager.currentOrder;

        foreach (var flower in order.flowers)
        {
            int playerAmount = inventory.GetItemCount(flower.Key);

            if (playerAmount < flower.Value)
            {
                Debug.Log("NOT ENOUGH "+flower.Key+"S");
                return false;
            }

            if (inventory.GetRibbon() != order.ribbon)
            {
                Debug.Log("Wrong ribbon");
                return false;
            }

            if (selectedWrapping != order.wrapping)
            {
                Debug.Log("Wrong Wrapping");
                return false;
            }
        }

        Debug.Log("Correct");
        return true;
    }
}
