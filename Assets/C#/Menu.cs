using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject MenuObject;

    bool menuzyoutai;

    public GameObject obj;

    // Update is called once per frame
    void Update()
    {

        if (menuzyoutai == false)
        {
            GetComponent<Button>().onClick.AddListener(() =>
            {
                MenuObject.gameObject.SetActive(true);
                menuzyoutai = true;
                obj.SetActive(false);   // –³Œø‚É‚·‚é;
            });
        }

        else
        {
            GetComponent<Button>().onClick.AddListener(() =>
            {
                MenuObject.gameObject.SetActive(false);
                menuzyoutai = false;
                obj.SetActive(true);
            });
        }

        if (menuzyoutai == false)
        {
            if (Input.GetButtonDown("Cancel"))
            {
                MenuObject.gameObject.SetActive(true);
                menuzyoutai = true;
            }
        }

        else
        {
            if (Input.GetButtonDown("Cancel"))
            {
                MenuObject.gameObject.SetActive(false);
                menuzyoutai = false;

            }
        }
    }
}
