using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : Interactable
{
    CharacterStats myStats;

    private void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    
    public override void Interact()
    {
        PlayerCombat playerCombat = PlayerManager.instance.player.GetComponent<PlayerCombat>();

        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
        }
    }
}
