using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//JESSE ALLAS

public class AM : MonoBehaviour
{
    public static AM instance; //there's only one sound
    public AudioSource s;
    
    // Start is called before the first frame update
    void Awake()
    {
    
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }


    void Update()
    {

    }

    void Start()
    {

    }
    public void Play()
    {


        s.Play();
    }




}
