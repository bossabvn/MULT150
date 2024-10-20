using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        
        if (mxVal > 0)
        
        {
            target.transform.Rotate(0f, 1f, 0f);
        }
        
        else if (mxVal < 0)
        {
            target.transform.Rotate(0f, -1f, 0f);
        }

        if (myVal > 0)
        {
            target.transform.Rotate(-1f, 0f, 0f);
        }
        else if (myVal < 0)
        {
            target.transform.Rotate(1f, 0f, 0f);
        }
    }
}
