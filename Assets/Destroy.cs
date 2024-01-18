using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private float timeUntilDestroy = 5f;
    private float mTime = 0;
    private void Update() {
        mTime += Time.deltaTime;
        if (mTime >= timeUntilDestroy) {
            Destroy(gameObject);
            mTime = 0;
        }
    }
}
