using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//JESSE ALLAS

public class UpdateScore : MonoBehaviour
{
    int hs;
    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        //orient screen
        Screen.orientation = ScreenOrientation.Portrait;

        //display the current highscore
        scoretext.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
