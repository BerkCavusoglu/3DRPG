using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyInfo",menuName = "EnemyData")]

public class EnemyData : ScriptableObject
{
    public Vector3 enemyScale;
    public string enemyName;
    public Color enemyColor;
}
