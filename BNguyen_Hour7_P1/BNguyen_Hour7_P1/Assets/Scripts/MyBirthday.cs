using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day = 0;
        int total = 1;

        bool shouldContinue = day <= 17;
        do
        {
            day = day + total;
            print(day);
        }
        while (day <= 16);

        print("I was born TODAY!");
        day = day + total;

        bool shouldContinue2 = day <= 29;
        do
        {
            day = day + total;
            print(day);
        }
        while (day <= 29);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
