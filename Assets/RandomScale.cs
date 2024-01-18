using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScale : MonoBehaviour
{
    [SerializeField] private Transform transform;
    [SerializeField] private float minScale;
    [SerializeField] private float maxScale;

    void Start() {
        float randomScale = Random.Range(minScale, maxScale);
        transform.localScale = Vector3.one * randomScale;
    }
}
