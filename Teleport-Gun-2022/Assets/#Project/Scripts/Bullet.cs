using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float force;
    public float x;

    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force);
    }

    void OnCollisionEnter(Collision collision)
    {
        playerTransform.position = collision.GetContact(0).point;
        Destroy(gameObject);
    }

}
