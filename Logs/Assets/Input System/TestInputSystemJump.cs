using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class TestInputSystemJump : MonoBehaviour
{
    private Rigidbody rigidbodyObject;
    private PlayerInput playerInput;
    private PlayerInputAction playerInputAction;
    private void Awake()
    {
        rigidbodyObject = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerInputAction = new PlayerInputAction();
        playerInputAction.Player.Enable();
        playerInputAction.Player.Jump.performed += Jump;

    }
    private void FixedUpdate()
    {
        Vector2 inputVector2 = playerInputAction.Player.Movement.ReadValue<Vector2>();
        float speed = 10f;
        rigidbodyObject.AddForce(new Vector3(inputVector2.x, 0, inputVector2.y) * speed, ForceMode.Force);
    }

    //movement performed

    public void Jump(InputAction.CallbackContext context)
    {

            Debug.Log("Jump! " + context.phase);
            rigidbodyObject.AddForce(Vector3.up * 5f, ForceMode.Impulse);

    }
}
