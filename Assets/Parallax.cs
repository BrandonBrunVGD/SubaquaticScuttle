using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] private Renderer renderer;

    public bool activateParallax = true;

    void Update() {
        
        renderer.material.mainTextureOffset += new Vector2(0f, speed * Time.deltaTime);
        
    }
}
