using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f; //Швидкість, можна змінити в інспекторі

    void Start()
    {
        
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D - Ліво/Право
        float moveZ = Input.GetAxis("Vertical"); //  W/S - Вперід/Назад

        Vector3 movement = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime; // Рух

        transform.position += movement; // Зміна в позиції об'єкту гравця
    }
}
