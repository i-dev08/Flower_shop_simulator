using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public InventoryManager inventory;

    public TMP_Text roseText;
    public TMP_Text tulipText;
    public TMP_Text sunflowerText;
    public UnityEngine.UI.Image ribbonIcon;

    public Sprite redRibbon;
    public Sprite blueRibbon;
    public Sprite yellowRibbon;


    void Update()
    {
        roseText.text = "X  "+inventory.GetItemCount(ItemType.Rose);

        tulipText.text = "X  "+inventory.GetItemCount(ItemType.Tulip);

        sunflowerText.text = "X  "+inventory.GetItemCount(ItemType.Sunflower);

        ribbonIcon.gameObject.SetActive(true);

        switch(inventory.GetRibbon())
        {
            case "Red":
                ribbonIcon.sprite = redRibbon;
                break;

            case "Blue":
                ribbonIcon.sprite = blueRibbon;
                break;

            case "Yellow":
                ribbonIcon.sprite = yellowRibbon;
                break;

            default:
                ribbonIcon.gameObject.SetActive(false);
                break;
        }
    }
}
