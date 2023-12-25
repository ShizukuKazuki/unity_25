using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_02 : MonoBehaviour
{
    [SerializeField] GameObject MenuObject;

    bool menuzyoutai;

    public GameObject obj;

    //public GameObject Imege;

    // Start is called before the first frame update
    void Start()
    {
        
      GetComponent<Button>().onClick.AddListener(() =>
      {
          MenuObject.gameObject.SetActive(false);
          menuzyoutai = false;
          obj.SetActive(true);
      });
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
