using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius;
    bool isTargetted = false;

    bool hasInteracted = false;
    public Transform player;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (isTargetted)
        {
            float distance = Vector3.Distance(player.position,transform.position);  
            if (distance <= radius && !hasInteracted )
            {
                hasInteracted=true;
                Interact();
            }
        }
    }
    public virtual void Interact()
    {

    }

    public void OnTargetted(Transform playerTransform)
    {
        isTargetted = true;
        player = playerTransform;
        hasInteracted = false;
    }
    public void NoTargetted()
    {
        isTargetted=false;
        player = null;
        hasInteracted = false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
