using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    Light greenLight;
    // Start is called before the first frame update
    void Start()
    {
        greenLight = GameObject.Find("LightBulb").GetComponent<Light>();
        greenLight.type = LightType.Point;
    }

    // Update is called once per frame
    void Update()
    {
        bool isKeyDown = Input.GetKey(KeyCode.L);
        if (isKeyDown == true)
        {
            greenLight.intensity = 2;
        }
        else if (isKeyDown == false)
        {
            greenLight.intensity = 0;
        }
    }
}
