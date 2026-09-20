using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class BouquetMenuUI : MonoBehaviour
{
    public TMP_Text wrappingText;
    public CraftingManager craftingManager;
    public OrderManager orderManager;
    public CostManager costManager;
    public PointsManager pointsManager;

    private string[] wrappingOptions =
    {
        "Red",
        "Blue",
        "Yellow",
        "Green"
    };

    private int currentWrappingIndex = 0;
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            CloseBouquetMenu();
        }
    }

    public void OpenBouquetMenu()
    {
        currentWrappingIndex = 0;
        UpdateWrappingText();

        gameObject.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PrevWrapping()
    {
        currentWrappingIndex--;

        if (currentWrappingIndex < 0)
        {
            currentWrappingIndex = wrappingOptions.Length - 1;
        }
        
        UpdateWrappingText();
    }

    public void NextWrapping()
    {
        currentWrappingIndex++;

        if (currentWrappingIndex >= wrappingOptions.Length)
        {
            currentWrappingIndex = 0;
        }

        UpdateWrappingText();
    }

    void UpdateWrappingText()
    {
        wrappingText.text = wrappingOptions[currentWrappingIndex];
    }

    public void CloseBouquetMenu()
    {
        gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ConfirmBouquet()
    {
        int cost = costManager.CostCalc();
        string selectedWrapping = wrappingOptions[currentWrappingIndex];
        bool isCorrect = craftingManager.ValidateBouquet(selectedWrapping);

        if (isCorrect)
        {
            Debug.Log("Success");
            pointsManager.AddPoints(cost);
        }
        else
        {
            Debug.Log("Wrong");
        }

        CloseBouquetMenu();
        orderManager.currentOrder = null;
    }
}
