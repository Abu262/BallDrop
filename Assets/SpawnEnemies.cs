using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//JESSE ALLAS

public class SpawnEnemies : MonoBehaviour
{
    Camera cam;

    float height;

    float width;

    public GameObject[] enemies; //list of all balls falling from the top

    public float secondsBetweenSpawn; //seconds between each ball spawning

    public float elapsedTime = 0.0f; //current timer

    float speedtime = 0.0f; //timer to count when we speed up

    public GameObject[] spawns; //spawn points
    //Vector3 worldPoint; //obsolete 

    public float speed = 5f; //start speed

    //int timer; //obsolete
    
    // Start is called before the first frame update
    void Start()
    {
        
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;

            Instantiate(enemies[Random.Range(0, 3)], spawns[Random.Range(0,4)].transform.position, Quaternion.identity);



        }

        speedtime += Time.deltaTime;

        if (speedtime > 10.0f && speed < 8.0f)
        {
            speedtime = 0;

            speed += 0.5f;
            secondsBetweenSpawn -= 0.05f;
            Debug.Log(secondsBetweenSpawn);

        }


    }
}
