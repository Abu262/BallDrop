using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//JESSE ALLAS

public class FollowFinger : MonoBehaviour
{

    private Vector3 position;
    float width = Screen.width / 2.0f;
    float height = Screen.height / 2.0f;
    private void Awake()
    {
        width = Screen.width / 2.0f;
        height = Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait; //orients screen

        //Sets things nicely so our coordinates work
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(width, 0, 5));
        position = new Vector3(worldPoint.x, 0.7f, 0.0f);
        /////
        
        transform.position = position; //sets the cube's position
    }

    // Update is called once per frame
    void Update()
    {
        // if left-mouse-button is being held OR there is at least one touch
        if (Input.touchCount > 0)
        {   
            Touch touch = Input.GetTouch(0); //get the first touch

            
            Vector3 pos = touch.position; //Get position

            //convert to screen
            pos = Camera.main.ScreenToWorldPoint(pos);
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 5));

            //move cube
            position = new Vector3( pos.x, worldPoint.y + 0.7f, 0.0f);
            transform.position = position;
           
        }

    }
}
