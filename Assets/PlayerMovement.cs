using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform playerPos;
    [SerializeField] private float mMoveSpeed = 10f;

    void FixedUpdate()
    {
        Vector3 mInput = new Vector3(0, Input.GetAxisRaw("Vertical"), 0);

        rb.MovePosition(transform.position + mInput * Time.deltaTime * mMoveSpeed);
    }
}
