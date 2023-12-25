using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gauge : MonoBehaviour
{
    public Image ÉQÅ[ÉW;
    float max = 1;
    float min = 0.12f;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ÉQÅ[ÉW.fillAmount -= 15 * (max - min) / 100 + min;
        }

        if (Input.GetMouseButtonDown(1))
        {
            ÉQÅ[ÉW.fillAmount -= 15 * (max - min) / 100 + min;
        }

    }
}
