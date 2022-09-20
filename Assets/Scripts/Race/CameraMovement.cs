using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   

    public Transform target;
    public float smoothing;

  

    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3
        (target.position.x + 6, target.position.y,
        -11);

        transform.position = Vector3.Lerp
        (transform.position,
        targetPosition, smoothing * Time.deltaTime);
    }
}
