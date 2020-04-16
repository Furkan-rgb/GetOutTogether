using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal= Input.GetAxis("Horizontal1");
        float vertical= Input.GetAxis("Vertical1");
        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
}
