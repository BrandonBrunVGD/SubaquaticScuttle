using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] objects;
    [SerializeField] private float spawnTime = 2f;
    [SerializeField] private float minHeight = 0;
    [SerializeField] private float maxHeight = 0;
    [SerializeField] private float minWidth = 0;
    [SerializeField] private float maxWidth = 0;
    private float timeUntilSpawn;

    private void Update() {
        if (GameManager.Instance.isPlaying) {
            SpawnLoop();
        }
    }

    private void SpawnLoop() {
        timeUntilSpawn += Time.deltaTime;

        if (timeUntilSpawn >= spawnTime) {
            Spawn();
            timeUntilSpawn = 0f;
        }
    }

    private void Spawn() {
        GameObject objectToSpawn = objects[Random.Range(0, objects.Length)];

        Vector3 spawnLocation = new Vector3(Random.Range(minWidth, maxWidth), Random.Range(minHeight, maxHeight), 0);
        
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnLocation, Quaternion.identity);

    }
}
