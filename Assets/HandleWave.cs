using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleWave : MonoBehaviour
{
    [SerializeField] private Transform transform;
    [SerializeField] private float endPoint;
    [SerializeField] public int numOfEnemies;
    [SerializeField] private float speed;

    void Update() {
        if (transform.position.y > endPoint) {
            transform.position += new Vector3(0,speed,0) * Time.deltaTime;
        }

        
    }
}
