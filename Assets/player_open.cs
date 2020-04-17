using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_open : MonoBehaviour
{
    public pickup_object po;

    void OnTriggerEnter(Collider collider) //methode voor het triggeren van een event
    {
        if(collider.gameObject.tag == "Player" && po.canOpen == true) //als het object in contact komt met een object dat getagged is als "Player"
        {
            print("Door opened"); //print deze tekst als bevestiging
            Destroy(gameObject); //vernietig het object
        }
    }
}
