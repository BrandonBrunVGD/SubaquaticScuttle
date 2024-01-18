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
        if (isPlayer) {
            if (Input.GetAxisRaw("Vertical") == 1) {    
              objectTransform.eulerAngles = Vector3.forward * mRotationAmount;
            }
            else if (Input.GetAxisRaw("Vertical") == -1) {
                objectTransform.eulerAngles = Vector3.forward * (mRotationAmount * -1);
            }
            else {
               objectTransform.eulerAngles = Vector3.forward * originRot;
            }
        }
        else {
            objectTransform.Rotate(0, 0, mRotationAmount);
        }
    }
}
