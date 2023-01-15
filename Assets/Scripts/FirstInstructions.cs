using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstInstructions : MonoBehaviour
{
    // Start is called before the first frame update
    public void Activate()
    {
        gameObject.SetActive(true);

    }

    public void DeActivate()
    {
        gameObject.SetActive(false);

    }

}
