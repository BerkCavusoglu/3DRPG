using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCountDown = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackCountDown -= Time.deltaTime;
    }
    public void Attack(CharacterStats targetStats)
    {
        if (attackCountDown <= 0)
        {
            targetStats.TakeDamage(10f);
            attackCountDown = 1f / attackSpeed;
        }
        
    }
}
