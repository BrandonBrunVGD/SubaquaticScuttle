using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private string[] tag;

    private void OnCollisionStay2D(Collision2D other) {
        //for (int i = 0; i < tag.Length; i++) {
        foreach (string i in tag) {
            if (other.transform.tag == i) {
                Destroy(gameObject);
                if (gameObject.tag == "Player") {
                    GameManager.Instance.GameOver();
                }
            }
        }
       
    }

}
