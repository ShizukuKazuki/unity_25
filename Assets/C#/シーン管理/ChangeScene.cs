using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StrideScene : MonoBehaviour
{
    public string SceneName;

    public FadeScene FadeScene;

    //public FadeScene FadeScene;

    // Start is called before the first frame update
    void Start()
    {
        //if (gameObject.CompareTag("Player"))
        //{
        //    SceneManager.LoadScene(SceneName);
        //    //FadeScene.LoadScene(SceneName);
        //};
    }

    // Update is called once per frame
    

    public void LoadSceneEvent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadScene(string sceneName)
    {
        GetComponent<Animator>().enabled = true;
        SceneName = sceneName;
    }

}