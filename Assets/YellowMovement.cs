using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//JESSE ALLAS

public class YellowMovement : MonoBehaviour
{
    SpawnEnemies SE;
    //GameObject Spawner;
    float ChangePoint;
    float newspot;
    GameObject spawn;
    public Rigidbody rb;
    Vector3 push;
    Vector3 shiftdown;
    Vector3 shiftup;

    /// /////
    //Yellow objects switch spots when halfway along their path
    ////////

    // Start is called before the first frame update
    void Start()
    {
        newspot = transform.position.x * (-1f); //opposite end of the screen is the newspot the ball will move to

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.25f); 

        SE = GameObject.FindGameObjectWithTag("Spawner").GetComponent<SpawnEnemies>();

        ChangePoint = 2f * Camera.main.orthographicSize / 2; //the interval at which the balll will switch sides


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        push = new Vector3(0, -1f * SE.speed, 0); //enemy movement

        //shift speeds
        shiftdown = new Vector3(-10f, -1f * SE.speed, 0);
        shiftup = new Vector3(10f, -1f * SE.speed, 0);

        if (transform.position.y < ChangePoint)
        {
            if (newspot - 1 < transform.position.x && transform.position.x < newspot + 1)
            {
                rb.velocity = push;
                transform.position = new Vector3(newspot, transform.position.y, transform.position.z);
            }
            else
            {
                if (transform.position.x > newspot)
                {
                    
                    rb.velocity = shiftdown;
                }
                else if (transform.position.x < newspot)
                {
                    rb.velocity = shiftup;
                }
                else
                {
                    //       Debug.Log(rb);
                    rb.velocity = push;
                }
            }
            
            
            
        }
    else
        {
     //       Debug.Log(rb);
            rb.velocity = push;
        }

    }
    

}
