using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInputSystemJump : MonoBehaviour
{
    private Rigidbody rigidbodyObject;

    private void Awake()
    {
        rigidbodyObject = GetComponent<Rigidbody>();
    }



    public void Jump()
    {
       Debug.Log("Jump!");
       rigidbodyObject.AddForce(Vector3.up * 0.5f,ForceMode.Impulse);
    }
}
