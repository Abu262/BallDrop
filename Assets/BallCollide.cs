using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class BallCollide : MonoBehaviour
{
    //public TMPro.text
    public TextMeshProUGUI scoretext;
  //  int score;
    // Start is called before the first frame update
    void Awake()
    {
        PlayerPrefs.SetInt("Score", 0);
        //score = 0;
        //scoretext = gameObject.GetComponent<TextMeshPro>();

        scoretext.text = PlayerPrefs.GetInt("Score", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "green")
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            Destroy(collision.collider.gameObject);
            //score += 1;
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score", 0) + 1);
            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score", 0));

            }
            scoretext.text = PlayerPrefs.GetInt("Score", 0).ToString();
        }
        AM.instance.Play();
    }
}
