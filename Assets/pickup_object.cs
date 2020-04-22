using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_object : MonoBehaviour
{
    public bool canOpen = false;

        void Start()
    {

    }

    void OnTriggerEnter(Collider collider) //methode voor het triggeren van een event
    {
        if(collider.gameObject.tag == "Player") //als het object in contact komt met een object dat getagged is als "Player"
        {
            print("Item picked up"); //print deze tekst als bevestiging
            //Destroy(gameObject); //vernietig het object
            gameObject.SetActive(false);
            canOpen = true;
        }
    }
}
