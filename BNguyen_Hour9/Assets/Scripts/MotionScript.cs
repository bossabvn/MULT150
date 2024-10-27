using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    private GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        targetObject = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        bool wVal = Input.GetKeyDown(KeyCode.UpArrow);
        float wwVal = 1;
        bool aVal = Input.GetKeyDown(KeyCode.LeftArrow);
        float aaVal = -1;
        bool sVal = Input.GetKeyDown(KeyCode.DownArrow);
        float ssVal = -1;
        bool dVal = Input.GetKeyDown(KeyCode.RightArrow);
        float ddVal = 1;
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            targetObject.transform.Translate(0, wwVal, 0);
            Debug.Log("Up Arrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            targetObject.transform.Translate(aaVal, 0, 0);
            Debug.Log("Left Arrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            targetObject.transform.Translate(0, ssVal, 0);
            Debug.Log("Down Arrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            targetObject.transform.Translate(ddVal, 0, 0);
            Debug.Log("Right Arrow key was pressed");
        }
    }
}
