using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {

        //��������1��0���Ő؂�ւ���
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;
        }

    }
}
