using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TableTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TableTrigger Success");
        // FindObjectOfType<GameManager>().NextLevel();
        //  GameEvents.current.CubeTriggerSuccess();
        FindObjectOfType<GameManager>().PlacedCubeSuccessfully();

    }
}
