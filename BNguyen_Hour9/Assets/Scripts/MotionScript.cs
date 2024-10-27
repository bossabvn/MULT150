using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float wVal = Input.GetKeyDown("w");
        float aVal = Input.GetKeyDown("a");
        float sVal = Input.GetKeyDown("s");
        float dVal = Input.GetKeyDown("d");
        if (Input.GetKeyDown("w"))
        {

            Debug.Log("W key was pressed");
        }
        if (Input.GetKeyDown("a"))
        {

            Debug.Log("A key was pressed");
        }
        if (Input.GetKeyDown("s"))
        {

            Debug.Log("S key was pressed");
        }
        if (Input.GetKeyDown("d"))
        {

            Debug.Log("D key was pressed");
        }
    }
}
