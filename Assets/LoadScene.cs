using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//JESSE ALLAS

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("GameScreen"); //calling this one by name because it's the only other scene
    }

    public void OpenPrivacyPolicy()
    {
        Application.OpenURL("https://sites.google.com/view/balldrop-privacy-policy/home?authuser=0");
    }
}
