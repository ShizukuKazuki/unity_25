using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class STEAGButton : MonoBehaviour
{
    public string SceneName;

    public STAGEScene STAGEScene;

    public FadeScene FadeScene;

    //public GameObject Image;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            //SceneManager.LoadScene(SceneName);
            STAGEScene.LoadScene(SceneName);
            FadeScene.LoadScene(SceneName);
            
        });
    }
    // Update is called once per frame
    void Update()
    {

    }
}
