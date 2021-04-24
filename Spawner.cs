using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 0.5f;
    private float randX = 0f;
    public GameObject Ghost_Prefab;
    private float nextTimeToSpawn = 0f;
    Vector2 spawnPosition;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(Ghost_Prefab, spawnPosition, Quaternion.identity);
            nextTimeToSpawn = Time.time + 2f / spawnRate;
            randX = Random.Range(-11, 11);
            spawnPosition = new Vector2(randX, 3.0f);
        }
    }
}
