using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Jnp_gauge : MonoBehaviour
{
    public Slider �Q�[�WJ;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            �Q�[�WJ.value -= 25;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
