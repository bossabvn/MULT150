using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     float health = 1004f;
     float poisonDamage = 125.5f;

            while (health >= 0)
            {
                print(health);
                health -= poisonDamage;
            }

            if (health <= 0)
            {
                print("Player has been cooked!");
            }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
