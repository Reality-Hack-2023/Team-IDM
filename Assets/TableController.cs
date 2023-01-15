using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GameEvents.current.onCubeTriggerSuccess += onCubePlaced;
    }

    // Update is called once per frame
    private void onCubePlaced()
    {
        Debug.Log("NextLevel");
        //  FindObjectOfType<GameManager>().NextLevel();
       // FindObjectOfType<GameManager>().PlacedCubeSuccessfully();
    }
}
