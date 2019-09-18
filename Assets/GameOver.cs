using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

//JESSE ALLAS

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //GAME OVER if the bottom hits a ball that isnt green
        if (collision.collider.gameObject.tag != "green")
        {
            SceneManager.LoadScene("MainMenu");
        }

        else
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score", 0) + 1); //set the player's current score
            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore", 0)) //if the current score is greater than the highscore
            {
                PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score", 0)); //set highschore equal to current score

            }
            scoretext.text = PlayerPrefs.GetInt("Score", 0).ToString(); //display score
        }
            Destroy(collision.collider.gameObject); //get rid of the ball

    }
}
