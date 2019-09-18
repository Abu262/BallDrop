using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMovement : MonoBehaviour
{

    Rigidbody rb;
    Vector3 push;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f);
        rb = GetComponent<Rigidbody>();
        push = new Vector3(-20f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = push;
    }
}
