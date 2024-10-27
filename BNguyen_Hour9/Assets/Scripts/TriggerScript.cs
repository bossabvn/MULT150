using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sphere is kinematic rigid body collider, Cube is static trigger collider");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        print(other.gameObject.name + " has entered the cube");
    }
    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is still in the cube");
    }
    void OnTriggerExit (Collider other)
    {
        print(other.gameObject.name + " has left the cube");
    }
    // Sphere is kinematic rigid body collider, Cube is static trigger collider
}
