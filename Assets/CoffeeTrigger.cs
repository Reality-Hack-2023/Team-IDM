using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TableTrigger Success");
        // FindObjectOfType<GameManager>().NextLevel();
        //  GameEvents.current.CubeTriggerSuccess();
        FindObjectOfType<GameManager>().PlacedBookSuccessfully();

    }
}
