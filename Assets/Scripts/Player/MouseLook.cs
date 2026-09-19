using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 0.1f;

    private Transform playerBody;
    private float verticalRotation = 0f;

    void Start()
    {
        playerBody = transform.parent;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if(Cursor.lockState != CursorLockMode.Locked) 
            return;

        if (Mouse.current == null)
            return;

        Vector2 mouseInput = Mouse.current.delta.ReadValue();

        float mouseX = mouseInput.x * mouseSensitivity;
        float mouseY = mouseInput.y * mouseSensitivity;

        playerBody.Rotate(Vector3.up * mouseX);

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -80f, 80f);

        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}