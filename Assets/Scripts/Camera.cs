using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camera : MonoBehaviour
{
    float mouseX = 0f;
    float mouseY = 0f;


    [SerializeField]
    private float sensitivity = 5f;

    private Player player;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player = gameObject.GetComponentInParent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
            mouseX += Input.GetAxis("Mouse X") * sensitivity;
            mouseY += Input.GetAxis("Mouse Y") * sensitivity * -1;
            float maxRotation = 60f;
            float minRotation = -60f;
            transform.eulerAngles = new Vector3(Mathf.Clamp(mouseY, minRotation, maxRotation), mouseX, 0);
            player.getView(new Vector3(Mathf.Clamp(mouseY, minRotation, maxRotation), mouseX, 0));
    }
}