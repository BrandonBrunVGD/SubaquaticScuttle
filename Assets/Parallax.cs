using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Renderer renderer;

    void Update() {
        renderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
    }
}
