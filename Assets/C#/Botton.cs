using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botton : MonoBehaviour
{
    public GameObject obj;

    //public BoxCollider bc;

    public void PauseGame()
    {

         
            obj.SetActive(false);   // �����ɂ���
 

    }

    public void PauseGame2()
    {

      
            obj.SetActive(true);   // �����ɂ�z
    }

}


