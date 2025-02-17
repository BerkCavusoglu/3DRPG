using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    Camera cam;                    
    PlayerMovement movement;       

    public Interactable target;     

    void Start()
    {
        cam = Camera.main;          
        movement = GetComponent<PlayerMovement>();  
    }

    
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;


        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))  
            {
                movement.Move(hit.point);  

                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)  
                {
                    SetTarget(interactable); 
                }
                else
                {
                    RemoveTarget(); 
                }
            }
        }
    }

  
    void SetTarget(Interactable newTarget)
    {
        if (newTarget != target) 
        {
            if (target != null)  
            {
                target.NoTargetted();
            }
            target = newTarget; 
            movement.FollowTarget(newTarget);  
        }

        newTarget.OnTargetted(transform); 
    }

  
    void RemoveTarget()
    {
        if (target != null)  
        {
            target.NoTargetted();  
            target = null;         
            movement.StopFollow(); 
        }
    }
}
