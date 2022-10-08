using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class TestInputSystemJump : MonoBehaviour
{
    private Rigidbody rigidbodyObject;
    private PlayerInput playerInput;

    private void Awake()
    {
        rigidbodyObject = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        PlayerInputAction playerInputAction = new PlayerInputAction();
        playerInputAction.Player.Enable();
        playerInputAction.Player.Jump.performed += Jump;

        playerInputAction.Player.Movement.performed += Movement_performed;
    }


    //movement performed


    private void Movement_performed(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        Vector2 inputVector2 = context.ReadValue<Vector2>();
        float speed = 10f;
        rigidbodyObject.AddForce(new Vector3(inputVector2.x, 0, inputVector2.y)* speed, ForceMode.Force); 
    }
    public void Jump(InputAction.CallbackContext context)
    {

            Debug.Log("Jump! " + context.phase);
            rigidbodyObject.AddForce(Vector3.up * 5f, ForceMode.Impulse);

    }
}
