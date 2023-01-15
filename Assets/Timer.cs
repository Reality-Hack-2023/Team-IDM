using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float cntdnw = 8.0f;
  //  public Text disvar;

    void OnEnable()
    {
        cntdnw = 5.0f;
    }
    void Update()
    {
        if (cntdnw > 0)
        {
            cntdnw -= Time.deltaTime;
        }
        double b = System.Math.Round(cntdnw, 2);
        //disvar.text = b.ToString();
        if (cntdnw < 0)
        {
            FindObjectOfType<GameManager>().NextLevel();
            Debug.Log("OutOfTime");
        }
    }


}