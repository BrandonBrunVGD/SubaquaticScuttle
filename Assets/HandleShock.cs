using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleShock : MonoBehaviour
{
    AudioManager am;
    [SerializeField] private Animator animator;
    [SerializeField] private float transitionTime;
    [SerializeField] private AudioClip zapSFX;

    private float timeUntilTransition;
    private float spriteRadius;

    void Start() {
        am = AudioManager.Instance;
    }
    void Update() {
        spriteRadius = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.x / 2 - 0.5f; 
        gameObject.GetComponent<CircleCollider2D>().radius = spriteRadius;

        timeUntilTransition += Time.deltaTime;

        if (timeUntilTransition >= transitionTime) {
            am.PlaySFX(zapSFX);
            animator.SetBool("isShocking", true);
            timeUntilTransition = 0; 
        }
    }

    private void Destroy()  {
        Destroy(gameObject);
    }
}
