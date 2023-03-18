using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformLurping : MonoBehaviour
{
    [SerializeField]
    float delta;

    [SerializeField]
    float speed = 1.0f;

    [SerializeField]
    Transform starting;

    [SerializeField]
    Transform ending;

    // Start is called before the first frame update
    void Start()
    {
        delta = 0.0f;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = (1 - delta) * starting.position + delta * ending.position;
        delta = Mathf.Cos(Time.time * speed) * 0.5f + 0.5f;
    }
}
