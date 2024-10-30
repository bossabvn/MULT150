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
        float wwVal = 1f / 2;
        bool aVal = Input.GetKeyDown(KeyCode.LeftArrow);
        float aaVal = -1f / 2;
        bool sVal = Input.GetKeyDown(KeyCode.DownArrow);
        float ssVal = -1f / 2;
        bool dVal = Input.GetKeyDown(KeyCode.RightArrow);
        float ddVal = 1f / 2;
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            targetObject.transform.Translate(0, wwVal, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            targetObject.transform.Translate(aaVal, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            targetObject.transform.Translate(0, ssVal, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            targetObject.transform.Translate(ddVal, 0, 0);
        }
    }
}
