using UnityEngine;
using TMPro;

public class FlowerQuantityCntrol : MonoBehaviour
{
    public FlowerMenuUI flowerMenu;
    public ItemType flower;
    public TMP_Text quantityText;

    public void AddOne()
    {
        flowerMenu.AddFlower(flower);
        UpdateQuantity();
    }

    public void RemoveOne()
    {
        flowerMenu.RemoveFlower(flower);
        UpdateQuantity();
    }

    public void UpdateQuantity()
    {
        quantityText.text = flowerMenu.GetSelectedFlowerCount(flower).ToString();
    }

    void OnEnable()
    {
        UpdateQuantity();
    }
}
