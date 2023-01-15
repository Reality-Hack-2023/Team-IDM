using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScreen : MonoBehaviour

{


    //public float restartDelay = 2f;
    //public Text progressText;
   // public float delayTime = 2f;


    public void Activate()
    {
        gameObject.SetActive(true);

    }

    public void DeActivate()
    { 
        gameObject.SetActive(false);
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene("livingroomScripted");
       // gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.Exit(0);
    }
}
