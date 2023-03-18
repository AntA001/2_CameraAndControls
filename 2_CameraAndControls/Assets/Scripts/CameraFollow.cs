using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    float cameraSpeed = 10.0f;

    [SerializeField]
    Transform idealCameraPosition;

    [SerializeField]
    Transform idealCameraTarget;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = idealCameraPosition.position;
        transform.LookAt(idealCameraTarget);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, idealCameraPosition.position, cameraSpeed *Time.deltaTime);
        transform.LookAt(idealCameraTarget);
        //Vector3 newDirection = Vector3.Normalize(idealCameraTarget.position - transform.position);
        //transform.Rotate(Vector3.RotateTowards(transform.forward, newDirection, 1.0f, 1.0f));
    }
}
