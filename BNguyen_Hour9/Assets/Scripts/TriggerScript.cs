using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject LTrigger;
    public GameObject RTrigger;
    public GameObject Sphere;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Sphere")
        print("Sphere has entered " + gameObject.name);
    }
    void OnTriggerStay (Collider other)
    {
        if (other.gameObject.name == "Sphere")
        print("Sphere is still in " + gameObject.name);
    }
    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.name == "Sphere")
        print("Sphere has left " + gameObject.name);
    }
    // Sphere is kinematic rigid body collider, Cube is static trigger collider
}
