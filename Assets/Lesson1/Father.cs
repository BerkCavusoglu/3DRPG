using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Father : MonoBehaviour
{
    public float health;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Interact()
    {
        Debug.Log("Hello I am father" + " " + "My health : "+ health);
    }
}
