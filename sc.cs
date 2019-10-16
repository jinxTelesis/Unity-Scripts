using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{

    public Camera one;
    public Camera two;
    private bool isOne = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0)) isOne = !isOne;

        one.enabled = isOne; two.enabled = !isOne;
      

    }
}
