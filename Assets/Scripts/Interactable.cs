using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public UnityEngine.AI.NavMeshAgent playerAgent;
    private bool hasInteracted;

    public virtual void MoveToInteraction(UnityEngine.AI.NavMeshAgent playerAgent)
    {

        hasInteracted = false;

        this.playerAgent = playerAgent;

        playerAgent.stoppingDistance = 1f;

        playerAgent.destination = this.transform.position;


      

    }

    void Update()
    {

        if (!hasInteracted && playerAgent != null && !playerAgent.pathPending)
        {

            if (playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {

                Interact();

                hasInteracted = true;

            }

        }

    }

    public virtual void Interact()
    {

        Debug.Log("Interacting with base class");

    }

}
