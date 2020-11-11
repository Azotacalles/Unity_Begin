using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject pointSpawnEnemy;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] pointsSpawnEnemy = GameObject.FindGameObjectsWithTag("PointSpawnEnemy");
        foreach (var item in pointsSpawnEnemy)
        {
            Instantiate(pointSpawnEnemy, item.transform.position, item.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
