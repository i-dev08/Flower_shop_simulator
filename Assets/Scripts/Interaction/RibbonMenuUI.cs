using UnityEngine;
using UnityEngine.InputSystem;
public class RibbonMenuUI : MonoBehaviour
{
    public InventoryManager inventory;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            CloseRibbonMenu();
        }
    }

    public void OpenRibbonMenu()
    {
        gameObject.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseRibbonMenu()
    {
        gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

   public void SelectRibbon(string color)
    {
        inventory.AddRibbon(color);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.pickup);

        CloseRibbonMenu();
    }
}
