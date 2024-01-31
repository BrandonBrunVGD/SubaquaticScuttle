using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    GameManager gm;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform playerPos;
    [SerializeField] private float mMoveSpeed = 10f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private AudioClip shootSFX;

    void Start() {
        gm = GameManager.Instance;
    }
    void FixedUpdate()
    {
        Vector3 mInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

        rb.MovePosition(transform.position + mInput * Time.deltaTime * mMoveSpeed);
        
    }

    private void Update() {

        if (Input.GetAxisRaw("Horizontal") == 1) {    
            playerPos.eulerAngles = Vector3.forward * (30 * -1);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1) {
            playerPos.eulerAngles = Vector3.forward * 30;
        }
        else {
            playerPos.eulerAngles = Vector3.forward * 0;
        }
        
    }

    public void SpawnBullet() {
        GameObject spawnObject = Instantiate(bullet, playerPos.position, Quaternion.identity);
        gm.am.PlaySFX(shootSFX);
    }
}
