using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Sink Success");
        // FindObjectOfType<GameManager>().NextLevel();
        //  GameEvents.current.CubeTriggerSuccess();
        FindObjectOfType<GameManager>().PlacedBottleSuccessfully();

    }
}
