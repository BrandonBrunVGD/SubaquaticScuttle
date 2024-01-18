using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    GameManager gm;

    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip coinSFX;
    private void Start() {
        gm = GameManager.Instance;
    }

    private void OnCollisionStay2D(Collision2D other) {
        
        if (other.transform.tag == "Obstacle") {
            gameObject.SetActive(false);
            GameManager.Instance.GameOver();
        }
        else if (other.transform.tag == "Shell") {
            gm.AddShells(1);
            source.clip = coinSFX;
            source.Play();
        }
       
    }
}
