using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePufferfish : MonoBehaviour
{
    AudioManager am;
    [SerializeField] private Animator animator;
    //[SerializeField] private float transitionTime;
    [SerializeField] private AudioClip spineSFX;
    [SerializeField] private GameObject bullet;

    private float transitionTime;
    private float timeUntilTransition;
    private float spriteRadius;

    void Start() {
        am = AudioManager.Instance;
        transitionTime = Random.Range(3.0f, 10.0f);
    }
    void Update() {
        spriteRadius = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size.x / 2 - 0.5f; 
        gameObject.GetComponent<CircleCollider2D>().radius = spriteRadius;

        timeUntilTransition += Time.deltaTime;

        if (timeUntilTransition >= transitionTime) {
            //am.PlaySFX(spineSFX);
            SpawnBullet();
            animator.SetBool("isAttacking", true);
            timeUntilTransition = 0; 
        }
    }

    void SetIsAttacking() {
        animator.SetBool("isAttacking", false);
    }

    private void SpawnBullet() {
        Vector3 spawnLocation = new Vector3(0,0,0);
    
        spawnLocation = transform.position;
        
        GameObject objectToSpawn = bullet;
        
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnLocation, objectToSpawn.transform.rotation);
    }
}
