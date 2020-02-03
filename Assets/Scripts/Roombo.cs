using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roombo : Enemy
{

    Enemy e = new Enemy();

    // Start is called before the first frame update
    void Start()
    {
        e.speed = 5;
        e.damage = 1;
        e.enemyID = 0;
        e.health = 1;
    }
}
