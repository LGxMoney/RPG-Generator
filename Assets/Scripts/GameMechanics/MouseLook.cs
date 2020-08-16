using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float fieldZoom = 40f;
    public float zoomRate = 4f;
    public float zoomCamRange = 3f;
    //public float zoomCamZ = 3f;
    public Transform playerBody;
    //public Transform flashLight;
    public Camera playerCam;
    


    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        float flashLightRotation = Mathf.Clamp(mouseY, -30f, 30f);
        //flashLight.localRotation = Quaternion.Euler()


        playerBody.Rotate(Vector3.up * mouseX);
        //flashLight.Rotate(Vector3.left * mouseY);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //flashLight.localRotation = Quaternion.Euler(xRotation, flashLightRotation, 0f);

        if (Input.GetKey(KeyCode.E))
        {
            if (playerCam.fieldOfView > fieldZoom)
            {
                playerCam.fieldOfView -= zoomRate;
            }
        }
        else
        {
            if (playerCam.fieldOfView <= 60f)
            {
                playerCam.fieldOfView += zoomRate;
            }
        }
    }
}
