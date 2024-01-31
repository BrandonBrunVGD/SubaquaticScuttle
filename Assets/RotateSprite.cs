using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSprite : MonoBehaviour
{
    [SerializeField] private bool isPlayer = false;
    [SerializeField] private float mRotationAmount;
    [SerializeField] private Transform objectTransform;
    [SerializeField] private float originRot = 0;
    private void Update() {
       
        objectTransform.Rotate(0, 0, mRotationAmount);
       
    }
}
