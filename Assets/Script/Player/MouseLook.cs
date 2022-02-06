using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    private PlayerControls PlayerControls;
    private InputAction CameraMovement;
    float xRotation = 0f;

    private void Awake()
    {
        PlayerControls = new PlayerControls();

    }

    private void OnEnable()
    {
        CameraMovement = PlayerControls.PlayerAction.CameraMovement;
        CameraMovement.Enable();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

   
    void Update()
    {
        float mouseX =  CameraMovement.ReadValue<Vector2>().x * mouseSensitivity * Time.deltaTime;
        float mouseY =  CameraMovement.ReadValue<Vector2>().y * mouseSensitivity * Time.deltaTime;

        

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //rotate self(camera)
        playerBody.Rotate(Vector3.up * mouseX); //roate playerbody


    }
}
