using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public InventoryManager inventory;

    public TMP_Text roseText;
    public TMP_Text tulipText;
    public TMP_Text sunflowerText;
    public TMP_Text ribbonText;


    void Update()
    {
        roseText.text = "Rose X "+inventory.GetItemCount(ItemType.Rose);

        tulipText.text = "Tulip X "+inventory.GetItemCount(ItemType.Tulip);

        sunflowerText.text = "Sunflower X "+inventory.GetItemCount(ItemType.Sunflower);

        ribbonText.text = "Ribbon: "+inventory.GetRibbon();
    }
}
