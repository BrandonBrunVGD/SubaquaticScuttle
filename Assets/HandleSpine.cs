using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleSpine : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 direction;

    void FixedUpdate() {
        rb.MovePosition(transform.position + direction * Time.deltaTime * moveSpeed);
    }
}
