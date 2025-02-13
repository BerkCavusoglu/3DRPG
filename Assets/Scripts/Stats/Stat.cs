using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]

public class Stat 
{
    [SerializeField]
    private float baseValeu;
    public List<float> modifiers;

    public float GetValue()
    {
        float finalValue = baseValeu; 

        foreach (float modifier in modifiers)
        {
            finalValue += modifier;
        }
        return finalValue;
    }
    
    public void AddModifiers(float newModifier)
    {
        modifiers.Add(newModifier);
    }
    public void RemoveModifiers(float newModifier)
    {
        modifiers.Remove(newModifier);
    }
}
