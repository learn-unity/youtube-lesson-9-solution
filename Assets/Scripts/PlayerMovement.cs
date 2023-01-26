using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedMovement = 7f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speedMovement * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - speedMovement * Time.deltaTime, transform.position.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + speedMovement * Time.deltaTime, transform.position.y);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speedMovement * Time.deltaTime);
        }
    }
}
