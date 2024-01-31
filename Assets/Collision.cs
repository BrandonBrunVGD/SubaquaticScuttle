using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameManager gm;
    [SerializeField] private string[] tag;
    [SerializeField] private AudioClip audioClip;
    private void Start() {
        gm = GameManager.Instance;
    }
    private void OnCollisionStay2D(Collision2D other) {
        //for (int i = 0; i < tag.Length; i++) {
        foreach (string i in tag) {
            if (other.transform.tag == i) {
                Destroy(gameObject);
                CheckForStatIncrease();
                if (audioClip != null && other.transform.tag != "Finish") {
                    gm.am.PlaySFX(audioClip);
                }
                //if (gameObject.tag == "Player") {
                //    GameManager.Instance.GameOver();
                //}
                if (gameObject.transform.tag == "Collectable") {
                    gm.AddLifeUI();
                    Debug.Log("Life Added");
                }
            }
        }
       
    }

    private void CheckForStatIncrease() {
        if (gameObject.tag == "JellyFish") {
            gm.jelliesKilled += 1;
        }
        else if (gameObject.tag == "Eel") {
            gm.eelsKilled += 1;
        }
    }

}
