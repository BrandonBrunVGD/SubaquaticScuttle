using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleBoss : MonoBehaviour
{
    GameManager gm;
    [SerializeField] private Animator animator;
    [SerializeField] private Renderer renderer;
    [SerializeField] private int maxHp;
    private float currentHp;
    private bool wasHit = false;
    private float blinkTimer = 0.3f;
    private float timeUntilBlink;
    void Start() {
        gm = GameManager.Instance;
        currentHp = maxHp;
        gameObject.GetComponent<Spawner>().SetSpawnerActive(false);
    }

    void Update() {
        if (wasHit) {
            renderer.material.color = Color.red;
            timeUntilBlink += Time.deltaTime;
            if (timeUntilBlink >= blinkTimer) {
                renderer.material.color = Color.white;
                wasHit = false;
                timeUntilBlink = 0;
            }
        }
        if (currentHp <= 0) {
            Destroy(gameObject);
            if (gameObject.transform.CompareTag("JellyFish")) {
                gm.jelliesKilled += 1;
            }
        }
        else if (currentHp == maxHp/2) {
            animator.SetBool("isEnraged", true);
            gameObject.GetComponent<Spawner>().SetSpawnerActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        
        if (other.transform.tag == "Bullet") {
            currentHp -= 1;
            wasHit = true;
        }
        
    }
}
