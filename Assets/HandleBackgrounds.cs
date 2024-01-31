using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleBackgrounds : MonoBehaviour
{
    GameManager gm;
    [SerializeField] private Transform transform; 
    private bool transition = false;
    private bool timerActive = true;

    void Start() {
        gm = GameManager.Instance;
    }

    void Update() {
        if (timerActive && gm.currentWave == 1) {
            transition = true;  
            timerActive = false;
        }

        if (transition) {
            transform.position += new Vector3(0, -2f * Time.deltaTime, 0);    
        }

        if (transform.position.y <= -9.46f) {
            transition = false;   
        }
    } 
}
