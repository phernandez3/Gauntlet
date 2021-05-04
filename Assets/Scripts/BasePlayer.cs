using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    // Player-controller stuff
    public int controllerSlot;

    // Basic stats
    public int score;
    public int health;
    public int keys;
    public int bombs;

    // Per class stats
    public int meleePower;
    public int rangePower;
    public float rangeSpeed;
    public GameObject bulletPrefab;
    public int armor;
    public float moveSpeed;
    public int magic;


}
