using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    GameManager gm;
    [SerializeField] private GameObject[] waves;

    private GameObject spawnedObject;
    private GameObject objectToSpawn;

    private int waveSwitch = 0;
    void Start() {
        gm = GameManager.Instance;
        Spawn(waves[0]);
    }

    void Update() {

        switch(waveSwitch) {
            case 0:
                if (gm.jelliesKilled >= waves[waveSwitch].GetComponent<HandleWave>().numOfEnemies) {
                    Destroy(spawnedObject);
                    gm.jelliesKilled = 0;
                    Spawn(waves[1]);
                    waveSwitch = 1;
                    gm.currentWave += 1;
                }
                break;
            case 1:
                if (gm.puffersKilled >= waves[waveSwitch].GetComponent<HandleWave>().numOfEnemies) {
                    Destroy(spawnedObject);
                    gm.puffersKilled = 0;
                    Spawn(waves[2]);
                    waveSwitch = 2;
                    gm.currentWave += 1;
                }
                break;
            case 2:
                if (gm.jelliesKilled >= waves[waveSwitch].GetComponent<HandleWave>().numOfEnemies) {
                    Destroy(spawnedObject);
                    gm.jelliesKilled = 0;
                    Spawn(waves[3]);
                    waveSwitch = 3;
                    gm.currentWave += 1;
                }
                break;
            case 3:
                if (gm.puffersKilled >= waves[waveSwitch].GetComponent<HandleWave>().numOfEnemies) {
                    Destroy(spawnedObject);
                    gm.puffersKilled = 0;
                    Spawn(waves[4]);
                    waveSwitch = 4;
                    gm.currentWave += 1;
                }
                break;
            case 4:
                if (gm.jelliesKilled >= waves[waveSwitch].GetComponent<HandleWave>().numOfEnemies) {
                    Destroy(spawnedObject);
                    gm.jelliesKilled = 0;
                    gm.GameWon();
                }
                break;
            default:
                break;
        }
        
    }

    private void Spawn(GameObject wave) {

        Vector3 spawnLocation = transform.position;

        objectToSpawn = wave;
        
        spawnedObject = Instantiate(objectToSpawn, spawnLocation, objectToSpawn.transform.rotation);
    }
}
