using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 2;
        int b = 4;
        int c = 8;
        int sum;

        sum = a + b + c; // sum = 2 + 4 + 8
        print (sum + 1);

        Debug.Log("a is " + a);
        Debug.Log("b is " + b);
        Debug.Log("c is " + c);
        Debug.Log("sum is " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
