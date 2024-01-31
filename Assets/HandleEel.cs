using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleEel : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private CapsuleCollider2D collider;
    [SerializeField] private float timeToShock;
    [SerializeField] private float shockDuration;
    [SerializeField] private Vector2 idleHitBox;
    [SerializeField] private Vector2 shockHitBox;
    private float timeUntilShock;
    private float timeUntilShockEnd;

    void Update() {
        timeUntilShock += Time.deltaTime;
        if (timeUntilShock >= timeToShock) {
            animator.SetBool("isShocking", true);
            collider.size = shockHitBox;

            timeUntilShockEnd += Time.deltaTime;
            if (timeUntilShockEnd >= shockDuration) {
                animator.SetBool("isShocking", false);
                timeUntilShock = 0;
                timeUntilShockEnd = 0;
                collider.size = idleHitBox;  
            }
        }
    }
}
