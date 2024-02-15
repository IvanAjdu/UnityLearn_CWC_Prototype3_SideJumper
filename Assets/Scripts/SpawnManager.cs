using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(30, 0, 0);
    //private float spawnDelay = 2f;
    //private float repeatRate = 1f;
    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        randomSpawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void randomSpawn()
    {
        float randomSpawnObstacle;
        if (Time.time < 20)
        {
            randomSpawnObstacle = Random.Range(1.5f, 3f);
        }
        else
        {
            randomSpawnObstacle = Random.Range(0.9f, 1.9f);
        }
        Invoke("spawnObstacle", randomSpawnObstacle);
    }
  
    void spawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
            randomSpawn();
        }
    }
}
