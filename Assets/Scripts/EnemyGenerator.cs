using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : BaseUnit
{
    [SerializeField] private GameObject enemyPrefab;     //Enemy type for THIS enemy generator goes here


    private void Awake()
    {
        healthPoints = 5;
    }


    //need to check adjacent spaces to generator (raycast)
    //coroutine spawning
}
