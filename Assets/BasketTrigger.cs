using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("BaskeetTrigger Success");
        // FindObjectOfType<GameManager>().NextLevel();
        //  GameEvents.current.CubeTriggerSuccess();
        FindObjectOfType<GameManager>().PlacedCandleSuccessfully();

    }
}
