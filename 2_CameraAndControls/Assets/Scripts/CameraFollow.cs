using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    float cameraSpeed = 10.0f;

    [SerializeField]
    float rotationSpeed = 2.0f;

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

        Vector3 targetDirection = Vector3.Normalize(idealCameraTarget.position - transform.position);
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, rotationSpeed * Time.deltaTime, 0.0f);

        transform.rotation = Quaternion.LookRotation(newDirection);   
    }
}
