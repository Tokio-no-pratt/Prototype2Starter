using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other. gameObject);
    }
}
