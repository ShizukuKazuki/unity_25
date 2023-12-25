using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject cleatText;
    public GameObject nextButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        cleatText.SetActive(true);
        nextButton.SetActive(true);
    }
}
