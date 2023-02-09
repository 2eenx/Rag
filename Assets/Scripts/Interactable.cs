using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public UnityEngine.AI.NavMeshAgent playerAgent;

    public virtual void MoveToInteraction(UnityEngine.AI.NavMeshAgent playerAgent)
    {

        this.playerAgent = playerAgent;

        playerAgent.stoppingDistance = 1f;

        playerAgent.destination = this.transform.position;


        Interact();

    }



    public virtual void Interact()
    {

        Debug.Log("Interacting with base class");

    }

}