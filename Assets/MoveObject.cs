using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float mMoveSpeed = 10;
    [SerializeField] private bool xAxis = true;
    [SerializeField] private bool yAxis = false;
   
    void FixedUpdate() {
        
        if (xAxis) {
            rb.MovePosition(transform.position + Vector3.left * Time.deltaTime * mMoveSpeed);
        }
        
        if (yAxis) {
            rb.MovePosition(transform.position + Vector3.up * Time.deltaTime * mMoveSpeed);
        }
        
    }
}
