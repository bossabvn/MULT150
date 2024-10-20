using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int healthpoints = 3992;
        int health = 400;
        healthpoints = UsePotion(healthpoints, health);
        healthpoints = UsePotion(healthpoints, health);
        healthpoints = UsePotion(healthpoints, health);
        healthpoints = UsePotion(healthpoints, health);
        healthpoints = UsePotion(healthpoints, health);
        Debug.Log(healthpoints);
    }
    

    // Update is called once per frame
    void Update()
    {

    }
    int UsePotion(int healthpoints, int health)
    {
        return healthpoints + health;
    }
}
  