using UnityEngine;
using TMPro;

public class OrderUI : MonoBehaviour
{

    public OrderManager orderManager;
    public TMP_Text orderText;


    void Update()
    {
        if (orderManager.currentOrder == null) {
            orderText.text = "No current order";
            return;
        }

        string text = "";

        foreach (var flower in orderManager.currentOrder.flowers)
        {
            text += flower.Key + " x " + flower.Value + "\n";
        }

        text += "\nRibbon: "+ orderManager.currentOrder.ribbon;

        text += "\nWrapping: "+ orderManager.currentOrder.wrapping;

        orderText.text = text;
    }
}
