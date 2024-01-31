using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    GameManager gm;
    [SerializeField] private AudioClip coinSFX;
    [SerializeField] private AudioClip hitSFX;
    private void Start() {
        gm = GameManager.Instance;
    }

    private bool wasHit = false;
    private bool canGetHit = true;
    private float iFramesDuration = 2;
    private float timeUntilIFramesEnd;
    private void OnCollisionEnter2D(Collision2D other) {
        
        if (other.transform.tag == "Obstacle" && canGetHit) {
            wasHit = true;
        }
        else if (other.transform.tag == "Shell") {
            gm.AddShells(1);
            gm.am.PlaySFX(coinSFX);
        }
        else if (other.transform.tag == "Enemy" && canGetHit) {  
            wasHit = true;
        }
        else if (other.transform.tag == "JellyFish" && canGetHit) {  
            wasHit = true;
        }
       
    }

    void Update() {
        if (wasHit && canGetHit) {  
            gm.am.PlaySFX(hitSFX);        
            gm.DestroyLifeUI();
            gm.playerLives -= 1;
            wasHit = false;
            canGetHit = false;
        }

        if (!canGetHit) {
            IFrames();
        }
    }
    private void IFrames() {
        timeUntilIFramesEnd += Time.deltaTime;

        if (timeUntilIFramesEnd >= iFramesDuration) {
            canGetHit = true;
            timeUntilIFramesEnd = 0;
        }
        
    }
}
