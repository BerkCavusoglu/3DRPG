using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child2 : Father
{
    public override void Interact()
    {
        base.Interact();
        GetComponent<Renderer>().material.color = Color.black;
    }
}
