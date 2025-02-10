using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float moveSpeed = 10f; 
    private float minZ = -17.5f; 
    private float maxZ = -4.45f; 

    void Update()
    {
        float moveZ = Input.GetAxis("Vertical");

        Vector3 currentPosition = transform.position;

        currentPosition.z += moveZ * moveSpeed * Time.deltaTime;

        currentPosition.z = Mathf.Clamp(currentPosition.z, minZ, maxZ);

        transform.position = new Vector3(currentPosition.x, currentPosition.y, currentPosition.z);
    }
}
