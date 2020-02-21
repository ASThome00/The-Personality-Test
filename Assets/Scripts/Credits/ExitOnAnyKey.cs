using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOnAnyKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey && (!Input.GetKeyDown(KeyCode.Mouse0) && !Input.GetKeyDown(KeyCode.Mouse1)))
        {
            Application.Quit();
        }
        
    }
}
