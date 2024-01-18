using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float mMoveSpeed = 10;

    void FixedUpdate() {
        //objectTransform.position -= new Vector3(mMoveSpeed, 0, 0);
        rb.MovePosition(transform.position + Vector3.left * Time.deltaTime * mMoveSpeed);
    }
}
