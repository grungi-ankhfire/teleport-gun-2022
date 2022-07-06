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
        if (collision.collider.tag != "Bounce")
        // Alternative : if (!collision.collider.CompareTag("Bounce"))
        {
            ContactPoint cp = collision.GetContact(0);
            if (Vector3.Angle(cp.normal, Vector3.up) <= 45) {
                playerTransform.position = cp.point;
                Destroy(gameObject);
            }
        }
    }

}
