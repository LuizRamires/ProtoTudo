using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpIfHitGround : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Ch�o")
        {
            rb.AddForce(transform.up * jumpForce * 50);
        }

    }
}
