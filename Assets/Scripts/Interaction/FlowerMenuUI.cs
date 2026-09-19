using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class FlowerMenuUI : MonoBehaviour
{
    public InventoryManager inventory;

    private Dictionary<ItemType, int> selectedFlowers = new Dictionary<ItemType, int>();

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            CloseFlowerMenu();
        }
    }

    public void OpenFlowerMenu()
    {
        selectedFlowers.Clear();

        gameObject.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseFlowerMenu()
    {
        selectedFlowers.Clear();

        gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void AddFlower(ItemType flower)
    {
        if (selectedFlowers.ContainsKey(flower))
        {
            selectedFlowers[flower]++;
        }
        else
        {
            selectedFlowers[flower] = 1;
        }
    }

    public void RemoveFlower(ItemType flower)
    {
        if (!selectedFlowers.ContainsKey(flower)) return;

        if (selectedFlowers[flower] > 0)
        {
            selectedFlowers[flower]--;
        }
    }

    public int GetSelectedFlowerCount(ItemType flower)
    {
        if (selectedFlowers.ContainsKey(flower))
        {
            return selectedFlowers[flower];
        }
        return 0;
    }
    
    public void ConfirmFlowerSelection()
    {
        foreach (KeyValuePair<ItemType, int> flower in selectedFlowers)
        {
            if (flower.Value > 0)
            {
                inventory.AddFlowerFinal(flower.Key, flower.Value);
            }
        }

        selectedFlowers.Clear();

        CloseFlowerMenu();
    }
}
