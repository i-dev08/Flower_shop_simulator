using UnityEngine;
using TMPro;

public class WorldOrderUI : MonoBehaviour
{
    public OrderManager orderManager;
    public CustomerManager customerManager;

    public GameObject orderPanel;

    // Flower rows
    public GameObject roseRow;
    public GameObject tulipRow;
    public GameObject sunflowerRow;

    // Flower text
    public TMP_Text roseText;
    public TMP_Text tulipText;
    public TMP_Text sunflowerText;

    // Other order items
    public TMP_Text ribbonText;
    public TMP_Text wrappingText;

    void Start()
    {
        orderPanel.SetActive(false);
    }

    void Update()
    {
        if (orderManager.currentOrder == null)
        {
            orderPanel.SetActive(false);
            return;
        }

        GameObject currentCustomer =
            customerManager.GetCurrentCustomer();

        if (currentCustomer == null)
        {
            orderPanel.SetActive(false);
            return;
        }

        Customer customer =
            currentCustomer.GetComponentInParent<Customer>();

        if (customer == null || !customer.IsWaitingAtCounter())
        {
            orderPanel.SetActive(false);
            return;
        }

        orderPanel.SetActive(true);

        UpdateOrderUI();
    }

    void UpdateOrderUI()
    {
        Order order = orderManager.currentOrder;

        // -------------------------
        // ROSE
        // -------------------------

        if (order.flowers.ContainsKey(ItemType.Rose))
        {
            roseRow.SetActive(true);

            roseText.text =
                "Rose × " + order.flowers[ItemType.Rose];
        }
        else
        {
            roseRow.SetActive(false);
        }


        // -------------------------
        // TULIP
        // -------------------------

        if (order.flowers.ContainsKey(ItemType.Tulip))
        {
            tulipRow.SetActive(true);

            tulipText.text =
                "Tulip × " + order.flowers[ItemType.Tulip];
        }
        else
        {
            tulipRow.SetActive(false);
        }


        // -------------------------
        // SUNFLOWER
        // -------------------------

        if (order.flowers.ContainsKey(ItemType.Sunflower))
        {
            sunflowerRow.SetActive(true);

            sunflowerText.text =
                "Sunflower × " + order.flowers[ItemType.Sunflower];
        }
        else
        {
            sunflowerRow.SetActive(false);
        }


        // -------------------------
        // RIBBON
        // -------------------------

        ribbonText.text =
            order.ribbon;


        // -------------------------
        // WRAPPING
        // -------------------------

        wrappingText.text =
            order.wrapping;
    }
}