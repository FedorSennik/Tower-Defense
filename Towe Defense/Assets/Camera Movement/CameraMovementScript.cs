using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public Transform Player;

    void Start()
    {
        
    }

    void Update()
    {
        
        if (Player != null)
        {
            transform.position = new Vector3(Player.position.x, transform.position.y, Player.position.z);
        }
    }
}
