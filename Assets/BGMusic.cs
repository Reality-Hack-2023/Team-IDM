using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audio1;
    public AudioClip audio2;

    public static BGMusic instance;

    void Awake()
    {
        //if (instance != null)
        //    Destroy(gameObject);
        //else
        //{
        //    instance = this;
        //    DontDestroyOnLoad(this.gameObject);
        //}
        if (SceneManager.GetActiveScene().name == "livingroomScripted")
        {
            audioSource.Stop();
            audioSource.clip = audio1;
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
            audioSource.clip = audio2;
            audioSource.Play();
        }
    }
}