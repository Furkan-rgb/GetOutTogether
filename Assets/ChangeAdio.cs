using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAdio : MonoBehaviour
{
    public pickup_object po;
    public AudioClip otherClip;

    void Update()
    {

        if(po.canOpen == true && GetComponent<AudioSource>().clip != otherClip)
        {
            GetComponent<AudioSource>().clip = otherClip;
            GetComponent<AudioSource>().Play ();
        }
    }
}
