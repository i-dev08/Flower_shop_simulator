using UnityEngine;

public class CraftingManager : MonoBehaviour
{
    public InventoryManager inventory;
    public OrderManager orderManager;
    public CustomerManager customerManager;

    public bool ValidateBouquet(string selectedWrapping)
    {
        if (orderManager.currentOrder == null)
        {
            return false;
        }
        Order order = orderManager.currentOrder;

        foreach (var flower in order.flowers)
        {
            int playerAmount = inventory.GetItemCount(flower.Key);

            if (playerAmount < flower.Value)
            {
                Debug.Log("NOT ENOUGH "+flower.Key+"S");
                MakeCustomerLeave();
                return false;
            }
        }

        if (inventory.GetRibbon() != order.ribbon)
        {
            Debug.Log("Wrong ribbon");
            MakeCustomerLeave();
            return false;
        }

        if (selectedWrapping != order.wrapping)
        {
            Debug.Log("Wrong Wrapping");
            MakeCustomerLeave();
            return false;
        }
        MakeCustomerLeave();
        return true;
    }

    void MakeCustomerLeave() 
    {
        GameObject currentCustomer = customerManager.GetCurrentCustomer();

        if (currentCustomer != null)
        {
            Customer customer = currentCustomer.GetComponentInParent<Customer>();

            if (customer != null)
            {
                customer.Leave();
            }
        }
    }
}
