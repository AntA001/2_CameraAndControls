using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;

    [SerializeField]
    float orbitRadius = 1.0f;

    [SerializeField]
    Transform orbitCenter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newX = Mathf.Cos(Time.time * speed) * orbitRadius;
        float newZ = Mathf.Sin(Time.time * speed) * orbitRadius;

        Vector3 newPosition = new Vector3 (newX, 0.0f, newZ);

        transform.position = newPosition + orbitCenter.position;   
    }
}
