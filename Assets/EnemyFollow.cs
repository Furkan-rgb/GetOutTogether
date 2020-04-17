using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour
{
    public GameObject ThePlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set destination van navmeshagent dat op enemy zit
        gameObject.GetComponent<NavMeshAgent>().SetDestination(ThePlayer.transform.position);
    }


        void OnTriggerEnter(Collider collider) //methode voor het triggeren van een event
    {
        if(collider.gameObject.tag == "Player") //als het object in contact komt met een object dat getagged is als "Player"
        {
            print("Player dead"); //print deze tekst als bevestiging
            SceneManager.LoadScene(2);
        }
    }
}
