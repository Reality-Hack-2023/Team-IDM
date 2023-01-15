using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;



    private void Awake()
    {
        current = this;
    }

    public event Action onCubeTriggerSuccess;
    public void CubeTriggerSuccess()
    {
        if(onCubeTriggerSuccess != null)
        {
            Debug.Log("GameEvents Success");
            onCubeTriggerSuccess();
        }

    }

}
