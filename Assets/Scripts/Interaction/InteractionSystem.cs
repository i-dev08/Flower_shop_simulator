using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionSystem : MonoBehaviour
{
    public float interactionRange = 3f;

    public FlowerMenuUI flowerMenu;
    public RibbonMenuUI ribbonMenu;
    public BouquetMenuUI bouquetMenu;
   
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactionRange))
        {
            if (hit.collider.CompareTag("Interactable"))
            {
                if (Keyboard.current.eKey.wasPressedThisFrame)
                {
                    if (hit.collider.gameObject.name == "FlowerCollision" )
                    {
                        flowerMenu.OpenFlowerMenu();
                    }
                    else if (hit.collider.gameObject.name == "RibbonCollision")
                    {
                        ribbonMenu.OpenRibbonMenu();
                    }
                    else if (hit.collider.gameObject.name == "BuildCollision")
                    {
                        bouquetMenu.OpenBouquetMenu();
                    }
                }
            }
        }
    }
}
