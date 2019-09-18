using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//JESSE ALLAS

public class BlueMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 push;
    SpawnEnemies SE;
    // Start is called before the first frame update

    //simple move down script

      
    void Start()
    {
        SE = GameObject.FindGameObjectWithTag("Spawner").GetComponent<SpawnEnemies>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        push = new Vector3(0, -1f * SE.speed, 0);
        rb.velocity = push;// * Time.fixedDeltaTime;
    }
}
