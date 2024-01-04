using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(30,0,0);
    private float spawnDelay = 2f;
    private float repeatRate = 2f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", spawnDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
