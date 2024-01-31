using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] objects;
    [SerializeField] private float minSpawnTime = 2f;
    [SerializeField] private float maxSpawnTime = 2f;
    [SerializeField] private float minHeight = 0;
    [SerializeField] private float maxHeight = 0;
    [SerializeField] private float minWidth = 0;
    [SerializeField] private float maxWidth = 0;
    [SerializeField] private bool spawnOnLocation = false;

    private float timeUntilSpawn;
    private float spawnTime;
    private bool spawnerActive = true;

    private void Start() {
        RandomSpawnTime();
    }

    private void Update() {
        if (GameManager.Instance.isPlaying) {
            if (spawnerActive) {
                SpawnLoop();
            }
        }
    }

    private void SpawnLoop() {
        timeUntilSpawn += Time.deltaTime;

        if (timeUntilSpawn >= spawnTime) {
            Spawn();
            RandomSpawnTime();
            timeUntilSpawn = 0f;
        }
    }

    private void Spawn() {
        Vector3 spawnLocation = new Vector3(0,0,0);
        
        if (!spawnOnLocation) {
            spawnLocation = new Vector3(Random.Range(minWidth, maxWidth), Random.Range(minHeight, maxHeight), 0);
        }
        else if (spawnOnLocation) {
            spawnLocation = transform.position;
        }
        
        GameObject objectToSpawn = objects[Random.Range(0, objects.Length)];
        
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnLocation, objectToSpawn.transform.rotation);

    }

    private void RandomSpawnTime() {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    public void SetSpawnerActive(bool active) {
        spawnerActive = active;
    }
}
