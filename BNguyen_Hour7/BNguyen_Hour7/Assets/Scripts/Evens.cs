using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int evens = 20;
        int total = 2;

        bool shouldContinue = evens <= 98;

        do
        {
            evens = evens + total;
            print(evens);

        }
        while (evens <= 98);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
