using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseLook : MonoBehaviour
{


    public float mouseSensitivity = 100f;

    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        float MouseX = Input.GetAxis("MouseX") * mouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("MouseY") * mouseSensitivity * Time.deltaTime;


        playerBody.Rotate(Vector3.up * MouseX);
    }
}
