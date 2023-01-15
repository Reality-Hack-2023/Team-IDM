using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bath Success");
        // FindObjectOfType<GameManager>().NextLevel();
        //  GameEvents.current.CubeTriggerSuccess();
        FindObjectOfType<GameManager>().PlacedPictureSuccessfully();

    }
}
