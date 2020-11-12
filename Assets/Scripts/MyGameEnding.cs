using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameEnding : MonoBehaviour
{
    private int enemies = 0;

    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("PointSpawnEnemy").Length;
    }

    void Update()
    {
        print(enemies);
        if(enemies == 0)
        {
            print("WIN!");
        }

    }

    public void ChangeEnemies()
    {
        print("Ch " + enemies);
        enemies--;
    }
}
