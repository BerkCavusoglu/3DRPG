using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child1 : Father
{
    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject, 2);
    }
}
