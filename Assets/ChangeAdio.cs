using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAdio : MonoBehaviour
{
    public pickup_object po;
    public AudioClip otherClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(po.canOpen == true && GetComponent<AudioSource>().clip != otherClip)
        {
            GetComponent<AudioSource>().clip = otherClip;
            GetComponent<AudioSource>().Play ();
        }
    }
}
