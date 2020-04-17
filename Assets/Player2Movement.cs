using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 6f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal2");
        float z = Input.GetAxis("Vertical2");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
