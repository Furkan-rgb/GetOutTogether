using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_movement : MonoBehaviour
{

    public float moveSpeed;
    //public float speed = 1.0f; //snelheid van ronddraaien

    // Use this for initialization
    void Start()
    {
        moveSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {//movement
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal2") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical2") * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Rotate2")*60.0f*Time.deltaTime, 0);
    }
}